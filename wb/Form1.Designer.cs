namespace wb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnLogin = new Material3.WinForms.Controls.MaterialButton();
            this.txtEmail = new Material3.WinForms.Controls.MaterialTextField();
            this.txtPassword = new Material3.WinForms.Controls.MaterialTextField();
            this.btnRegister = new Material3.WinForms.Controls.MaterialButton();
            this.wBDataSet = new wb.WBDataSet();
            this.usersTableAdapter = new wb.WBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new wb.WBDataSetTableAdapters.TableAdapterManager();
            this.materialThemeManager1 = new Material3.WinForms.MaterialThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.wBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialThemeManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(41, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Добро пожаловать!";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(115, 46);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(163, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Войдите или создайте аккаунт";
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.btnLogin.Location = new System.Drawing.Point(37, 223);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.LabelText = "login";
            this.txtEmail.Location = new System.Drawing.Point(37, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 71);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.LabelText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(37, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(328, 71);
            this.txtPassword.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegister.Location = new System.Drawing.Point(213, 223);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(152, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // wBDataSet
            // 
            this.wBDataSet.DataSetName = "WBDataSet";
            this.wBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.OrdersItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductViewsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = wb.WBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // materialThemeManager1
            // 
            this.materialThemeManager1.IsDark = false;
            this.materialThemeManager1.Seed = System.Drawing.Color.Black;
            this.materialThemeManager1.Variant = Material3.Core.SchemeVariant.Neutral;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 307);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Маркетплейс";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialThemeManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private Material3.WinForms.Controls.MaterialButton btnLogin;
        private Material3.WinForms.Controls.MaterialTextField txtEmail;
        private Material3.WinForms.Controls.MaterialTextField txtPassword;
        private Material3.WinForms.Controls.MaterialButton btnRegister;
        private WBDataSet wBDataSet;
        private WBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private WBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Material3.WinForms.MaterialThemeManager materialThemeManager1;
    }
}

