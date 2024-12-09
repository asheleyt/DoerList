namespace DoerList
{
    partial class RegistrationUI
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
            btnRegister = new Button();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            txtBoxUsername = new TextBox();
            lblUsername = new Label();
            txtBoxCfmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gainsboro;
            btnRegister.Font = new Font("Rockwell", 10F);
            btnRegister.Location = new Point(236, 192);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(96, 32);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(157, 110);
            txtBoxPassword.Margin = new Padding(4, 3, 4, 3);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(194, 25);
            txtBoxPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Rockwell", 11F);
            lblPassword.Location = new Point(74, 113);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 17);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Font = new Font("Rockwell", 11F);
            txtBoxUsername.Location = new Point(157, 74);
            txtBoxUsername.Margin = new Padding(4, 3, 4, 3);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(194, 25);
            txtBoxUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Rockwell", 11F);
            lblUsername.Location = new Point(74, 77);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(79, 17);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // txtBoxCfmPassword
            // 
            txtBoxCfmPassword.Location = new Point(157, 147);
            txtBoxCfmPassword.Margin = new Padding(4, 3, 4, 3);
            txtBoxCfmPassword.Name = "txtBoxCfmPassword";
            txtBoxCfmPassword.PasswordChar = '*';
            txtBoxCfmPassword.Size = new Size(194, 25);
            txtBoxCfmPassword.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 11F);
            label1.Location = new Point(13, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 17);
            label1.TabIndex = 12;
            label1.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 199);
            label2.Name = "label2";
            label2.Size = new Size(207, 17);
            label2.TabIndex = 14;
            label2.Text = "Register Your Account Now ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 16F, FontStyle.Bold);
            label3.Location = new Point(111, 18);
            label3.Name = "label3";
            label3.Size = new Size(208, 27);
            label3.TabIndex = 15;
            label3.Text = "Registration Form";
            // 
            // RegistrationUI
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(433, 236);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxCfmPassword);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(lblUsername);
            Font = new Font("Rockwell", 11F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationUI";
            Text = "RegistrationUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtBoxPassword;
        private Label lblPassword;
        private TextBox txtBoxUsername;
        private Label lblUsername;
        private TextBox txtBoxCfmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}