using System.Windows.Forms;

namespace GUI.UserManagement.Forms
{
    internal class Routing
    {
        private LoginForm loginForm;
        private RegisterForm registerForm;
        private ForgotPassword forgotPassword;


        public void ShowLoginForm(Form currentForm)
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
            }
            loginForm.Show();
            currentForm.Close();
        }

        public void ShowRegisterForm(Form currentForm)
        {
            if (registerForm == null)
            {
                registerForm = new RegisterForm();
            }
            registerForm.ShowDialog();
            currentForm.Hide();
        }
        public void ShowForgotPasswordForm(Form currentForm)
        {
            if (forgotPassword == null)
            {
                forgotPassword = new ForgotPassword();
            }
            forgotPassword.Show();
            currentForm.Hide();
        }
    }
}