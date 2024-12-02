using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoerList
{
    public partial class PassForm : Form
    {
        private readonly string loggedInUsername;

        public PassForm(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtBoxCurrentPassword.Text.Trim();
            string newPassword = txtBoxNewPassword.Text.Trim();
            string confirmPassword = txtBoxConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }

            if (FileDatabaseHelper.ChangePassword(loggedInUsername, currentPassword, newPassword))
            {
                MessageBox.Show("Password changed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to change password. Please check your current password and try again.");
            }
        }
    }
}
