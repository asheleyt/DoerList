namespace DoerList
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with the login form
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Pass the username from the login form to the main form
                string username = loginForm.Username; // Add a property to LoginForm to expose the username
                Application.Run(new MainForm(username));
            }
        }
    }
}