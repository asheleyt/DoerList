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
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (currentPassword == newPassword)
            {
                MessageBox.Show("New password cannot be the same as the current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (!FileDatabaseHelper.IsValidPassword(newPassword))
            {
                MessageBox.Show("New password must be at least 8 characters long and include letters, numbers, and special characters.",
                                "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            var result = MessageBox.Show("Are you sure you want to change your password?",
                                         "Confirm Password Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

      
            if (FileDatabaseHelper.ChangePassword(loggedInUsername, currentPassword, newPassword))
            {
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
                txtBoxCurrentPassword.Clear();
                txtBoxNewPassword.Clear();
                txtBoxConfirmPassword.Clear();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please check your current password and try again.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
           
            btnChangePassword.Enabled = !string.IsNullOrWhiteSpace(txtBoxCurrentPassword.Text) &&
                                         !string.IsNullOrWhiteSpace(txtBoxNewPassword.Text) &&
                                         !string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text);
        }

        private void PassForm_Load(object sender, EventArgs e)
        {
            
            txtBoxCurrentPassword.TextChanged += TextBox_TextChanged;
            txtBoxNewPassword.TextChanged += TextBox_TextChanged;
            txtBoxConfirmPassword.TextChanged += TextBox_TextChanged;

           
            btnChangePassword.Enabled = false;
        }
    }
}
