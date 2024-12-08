namespace DoerList
{
    public partial class LoginForm : Form
    {
        public string Username { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            FileDatabaseHelper.Initialize();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text.Trim();

            if (FileDatabaseHelper.ValidateUser(username, password))
            {
                Username = username; 
                this.DialogResult = DialogResult.OK; 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationUI registrationUI = new RegistrationUI();
            registrationUI.ShowDialog();
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {
                string username = txtBoxUsername.Text.Trim();
                PassForm passForm = new PassForm(username);
                passForm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Please enter your username before changing the password.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}