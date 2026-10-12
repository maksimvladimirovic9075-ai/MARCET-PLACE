using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace wb
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            btnSubmitRegister.Click += btnSubmitRegister_Click;
        }

        private string EncodePassword(string password)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);

            return Convert.ToBase64String(bytes);
        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtRegEmail.Text.Trim();
            string password = txtRegPassword.Text;
            string confirm = txtConfirmPassword.Text;

            if (name == "" || email == "" ||
                password == "" || confirm == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Введите корректную почту.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать минимум 6 символов.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            try
            {
                var adapter =
                    new WBDataSetTableAdapters.UsersTableAdapter();

                int count = Convert.ToInt32(adapter.CheckEmail(email));

                if (count > 0)
                {
                    MessageBox.Show("Эта почта уже зарегистрирована.");
                    return;
                }

                string passwordHash = EncodePassword(password);

                adapter.Reg(name, email, passwordHash, "User");

                MessageBox.Show("Регистрация прошла успешно!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Ошибка регистрации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}