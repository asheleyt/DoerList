namespace DoerList
{
    partial class LoginForm
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
            lblUsername = new Label();
            txtBoxUsername = new TextBox();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            BtnChangePass = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(21, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(101, 19);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(125, 23);
            txtBoxUsername.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(101, 59);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(125, 23);
            txtBoxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(21, 59);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(101, 99);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(189, 99);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // BtnChangePass
            // 
            BtnChangePass.Location = new Point(21, 141);
            BtnChangePass.Margin = new Padding(2);
            BtnChangePass.Name = "BtnChangePass";
            BtnChangePass.Size = new Size(118, 25);
            BtnChangePass.TabIndex = 6;
            BtnChangePass.Text = "Change Password";
            BtnChangePass.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 177);
            Controls.Add(BtnChangePass);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtBoxUsername;
        private TextBox txtBoxPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button BtnChangePass;
    }
}