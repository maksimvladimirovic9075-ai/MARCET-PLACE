namespace wb
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.txtName = new Material3.WinForms.Controls.MaterialTextField();
            this.txtRegEmail = new Material3.WinForms.Controls.MaterialTextField();
            this.txtConfirmPassword = new Material3.WinForms.Controls.MaterialTextField();
            this.txtRegPassword = new Material3.WinForms.Controls.MaterialTextField();
            this.btnSubmitRegister = new Material3.WinForms.Controls.MaterialButton();
            this.wbDataSet1 = new wb.WBDataSet();
            this.materialThemeManager1 = new Material3.WinForms.MaterialThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.wbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialThemeManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.LabelText = "Имя Фамилия";
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 71);
            this.txtName.TabIndex = 0;
            this.txtName.Variant = Material3.WinForms.Controls.MaterialTextFieldVariant.Outlined;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtRegEmail.LabelText = "Электронная почта";
            this.txtRegEmail.Location = new System.Drawing.Point(12, 65);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(302, 71);
            this.txtRegEmail.TabIndex = 1;
            this.txtRegEmail.Variant = Material3.WinForms.Controls.MaterialTextFieldVariant.Outlined;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmPassword.LabelText = "Повторите пароль";
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 171);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(302, 60);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.Variant = Material3.WinForms.Controls.MaterialTextFieldVariant.Outlined;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtRegPassword.LabelText = "Пароль";
            this.txtRegPassword.Location = new System.Drawing.Point(12, 118);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(302, 57);
            this.txtRegPassword.TabIndex = 3;
            this.txtRegPassword.Variant = Material3.WinForms.Controls.MaterialTextFieldVariant.Outlined;
            // 
            // btnSubmitRegister
            // 
            this.btnSubmitRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitRegister.FlatAppearance.BorderSize = 0;
            this.btnSubmitRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmitRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmitRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnSubmitRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.btnSubmitRegister.Location = new System.Drawing.Point(53, 247);
            this.btnSubmitRegister.Name = "btnSubmitRegister";
            this.btnSubmitRegister.Size = new System.Drawing.Size(219, 40);
            this.btnSubmitRegister.TabIndex = 4;
            this.btnSubmitRegister.Text = "Зарегистрироваться";
            this.btnSubmitRegister.UseVisualStyleBackColor = false;
            // 
            // wbDataSet1
            // 
            this.wbDataSet1.DataSetName = "WBDataSet";
            this.wbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialThemeManager1
            // 
            this.materialThemeManager1.IsDark = false;
            this.materialThemeManager1.Seed = System.Drawing.Color.Black;
            this.materialThemeManager1.Variant = Material3.Core.SchemeVariant.Neutral;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 323);
            this.Controls.Add(this.btnSubmitRegister);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.wbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialThemeManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Material3.WinForms.Controls.MaterialTextField txtName;
        private Material3.WinForms.Controls.MaterialTextField txtRegEmail;
        private Material3.WinForms.Controls.MaterialTextField txtConfirmPassword;
        private Material3.WinForms.Controls.MaterialTextField txtRegPassword;
        private Material3.WinForms.Controls.MaterialButton btnSubmitRegister;
        private WBDataSet wbDataSet1;
        private Material3.WinForms.MaterialThemeManager materialThemeManager1;
    }
}