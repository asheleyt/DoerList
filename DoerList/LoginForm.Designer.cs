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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Rockwell", 11F);
            lblUsername.Location = new Point(86, 69);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(79, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Font = new Font("Rockwell", 11F);
            txtBoxUsername.Location = new Point(167, 66);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(127, 25);
            txtBoxUsername.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Rockwell", 11F);
            txtBoxPassword.Location = new Point(167, 106);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(127, 25);
            txtBoxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Rockwell", 11F);
            lblPassword.Location = new Point(86, 109);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 17);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gainsboro;
            btnLogin.Font = new Font("Rockwell", 11F);
            btnLogin.Location = new Point(314, 83);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gainsboro;
            btnRegister.Font = new Font("Rockwell", 11F);
            btnRegister.Location = new Point(268, 150);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(77, 32);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // BtnChangePass
            // 
            BtnChangePass.BackColor = Color.Gainsboro;
            BtnChangePass.Font = new Font("Rockwell", 11F);
            BtnChangePass.Location = new Point(180, 215);
            BtnChangePass.Margin = new Padding(2);
            BtnChangePass.Name = "BtnChangePass";
            BtnChangePass.Size = new Size(165, 25);
            BtnChangePass.TabIndex = 6;
            BtnChangePass.Text = "Change Password";
            BtnChangePass.UseVisualStyleBackColor = false;
            BtnChangePass.Click += BtnChangePass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 11F);
            label1.Location = new Point(43, 219);
            label1.Name = "label1";
            label1.Size = new Size(132, 17);
            label1.TabIndex = 7;
            label1.Text = "Forgot Password?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            label2.Location = new Point(86, 22);
            label2.Name = "label2";
            label2.Size = new Size(270, 29);
            label2.TabIndex = 8;
            label2.Text = "Welcome To Doerlist!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 11F);
            label3.Location = new Point(60, 158);
            label3.Name = "label3";
            label3.Size = new Size(202, 17);
            label3.TabIndex = 9;
            label3.Text = "Dont Have An Account Yet?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(427, 259);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}