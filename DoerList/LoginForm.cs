using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FileDatabaseHelper.Initialize(); // Initialize the file database
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            if (FileDatabaseHelper.ValidateUser(username, password))
            {
                MainForm mainForm = new MainForm(username);
                mainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationUI registrationUI = new RegistrationUI();
            registrationUI.Show();
            this.Close();
        }
    }
}