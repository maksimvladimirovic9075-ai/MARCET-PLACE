using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace wb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckPassword(string password, string savedPassword)
        {
            if (password == savedPassword)
                return true;

            try
            {
                string decodedPassword = System.Text.Encoding.UTF8.GetString(
                    Convert.FromBase64String(savedPassword));

                return password == decodedPassword;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Введите почту и пароль.");
                return;
            }

            try
            {
                var adapter =
                    new WBDataSetTableAdapters.UsersTableAdapter();

                DataTable users = adapter.LoginQuery(email);

                if (users.Rows.Count == 0)
                {
                    MessageBox.Show("Пользователь не найден.");
                    return;
                }

                DataRow user = users.Rows[0];

                string savedHash = user["PasswordHash"].ToString();

                if (!CheckPassword(password, savedHash))
                {
                    MessageBox.Show("Неверный пароль.");
                    return;
                }

                string role = user["Role"].ToString();

                Form nextForm;

                if (role == "Admin")
                    nextForm = new AdminForm();
                else if (role == "User")
                    nextForm = new UserForm();
                else
                {
                    MessageBox.Show("Неизвестная роль пользователя.");
                    return;
                }

                Hide();

                nextForm.FormClosed += (s, args) => Close();

                nextForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка входа: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (RegisterForm form = new RegisterForm())
            {
                form.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}