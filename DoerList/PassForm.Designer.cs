namespace DoerList
{
    partial class PassForm
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
            lblCurrentPassword = new Label();
            txtBoxCurrentPassword = new TextBox();
            txtBoxNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtBoxConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            btnChangePassword = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Rockwell", 11F);
            lblCurrentPassword.Location = new Point(12, 63);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(138, 17);
            lblCurrentPassword.TabIndex = 0;
            lblCurrentPassword.Text = "Current Password:";
            // 
            // txtBoxCurrentPassword
            // 
            txtBoxCurrentPassword.Font = new Font("Rockwell", 11F);
            txtBoxCurrentPassword.Location = new Point(147, 60);
            txtBoxCurrentPassword.Name = "txtBoxCurrentPassword";
            txtBoxCurrentPassword.Size = new Size(149, 25);
            txtBoxCurrentPassword.TabIndex = 1;
            // 
            // txtBoxNewPassword
            // 
            txtBoxNewPassword.Font = new Font("Rockwell", 11F);
            txtBoxNewPassword.Location = new Point(147, 101);
            txtBoxNewPassword.Name = "txtBoxNewPassword";
            txtBoxNewPassword.PasswordChar = '*';
            txtBoxNewPassword.Size = new Size(149, 25);
            txtBoxNewPassword.TabIndex = 3;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Rockwell", 11F);
            lblNewPassword.Location = new Point(26, 104);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(115, 17);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password:";
            // 
            // txtBoxConfirmPassword
            // 
            txtBoxConfirmPassword.Font = new Font("Rockwell", 11F);
            txtBoxConfirmPassword.Location = new Point(147, 142);
            txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            txtBoxConfirmPassword.PasswordChar = '*';
            txtBoxConfirmPassword.Size = new Size(149, 25);
            txtBoxConfirmPassword.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Rockwell", 11F);
            lblConfirmPassword.Location = new Point(10, 145);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(140, 17);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.Gainsboro;
            btnChangePassword.Font = new Font("Rockwell", 10F);
            btnChangePassword.Location = new Point(124, 188);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(84, 31);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14F);
            label1.Location = new Point(78, 21);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 7;
            label1.Text = "Change Password";
            // 
            // PassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(333, 231);
            Controls.Add(label1);
            Controls.Add(btnChangePassword);
            Controls.Add(txtBoxConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtBoxNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtBoxCurrentPassword);
            Controls.Add(lblCurrentPassword);
            Name = "PassForm";
            Text = "Change Password";
            Load += PassForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentPassword;
        private TextBox txtBoxCurrentPassword;
        private TextBox txtBoxNewPassword;
        private Label lblNewPassword;
        private TextBox txtBoxConfirmPassword;
        private Label lblConfirmPassword;
        private Button btnChangePassword;
        private Label label1;
    }
}