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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtBoxUsername.Text;
            String password = txtBoxPassword.Text;

            if (username == "User" && password == "password")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();


                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
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