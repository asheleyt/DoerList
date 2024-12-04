namespace DoerList
{
    public partial class RegistrationUI : Form
    {
        public RegistrationUI()
        {
            InitializeComponent();
        }
        public string RegisteredUsername { get; private set; }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text.Trim();
            string confirmPassword = txtBoxCfmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill up the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FileDatabaseHelper.RegisterUser(username, password))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxUsername.Clear();
                txtBoxPassword.Clear();
                txtBoxCfmPassword.Clear();
            }
            else
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (FileDatabaseHelper.RegisterUser(username, password))
            {
                RegisteredUsername = username; 
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
    }
}


