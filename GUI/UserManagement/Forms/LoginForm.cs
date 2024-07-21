using BLL.Services;
using GUI.Components;
using GUI.Messaging.Forms;
using GUI.NewsFeed.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using GUI.AppSettings;

namespace GUI.UserManagement.Forms
{
    public partial class LoginForm : BaseFormLogin
    {
        private Routing routing;
        AuthenticationService authService;
        SessionService sessionService;

        public LoginForm()
        {
            InitializeComponent();
            routing = new Routing();
            authService = new AuthenticationService();
            sessionService = new SessionService();

            PasswordDesign();

            //Darkmode
            DarkMode.OnDarkModeChanged += DarkMode_OnDarkModeChanged;
            UpdateUIBasedOnDarkMode(DarkMode.IsDarkModeEnabled);

            //English
            Language.OnEnglishChanged += English_OnEnglishChanged;
            UpdateUIBasedOnEnglish(Language.IsEnglishEnabled);
        }
        void PasswordDesign()
        {
            string strPassPlaceholder = CtxtPassword.PlaceholderText;

            if (strPassPlaceholder == "Mật khẩu" || strPassPlaceholder == "Password" || CtxtPassword.Text == "")
            {
                CtxtPassword.PasswordChar = false;
            }
            else
            {
                CtxtPassword.PasswordChar = true;
            }
        }

        private void CbtnLogin_Click(object sender, EventArgs e)
        {
            string username = CtxtEmail.Texts;
            string password = CtxtPassword.Texts;

            int loginSuccessful = authService.Login(username, password);

            if (loginSuccessful != 0)
            {
                this.Hide();
                // Đăng nhập thành công
                int sessionIdReturn;
                sessionIdReturn = sessionService.CreateSession(loginSuccessful, true);
                SessionManager.SetSession(sessionIdReturn);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                //ChatForm chatForm = new ChatForm();
                //chatForm.Show();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void CbtnRegister_Click(object sender, EventArgs e)
        {
            routing.ShowRegisterForm(this);
        }
        private void btnChangeLan_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LoginForm: laguage: " + Language.IsEnglishEnabled);
            if (Language.IsEnglishEnabled == false)
            {
                Language.IsEnglishEnabled = true;
            }
            else
            {
                Language.IsEnglishEnabled = false;
            }
        }
        private void llblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            routing.ShowForgotPasswordForm(this);
        }

        # region -> Language
        private void English_OnEnglishChanged(bool isEnglishEnabled)
        {
            UpdateUIBasedOnEnglish(isEnglishEnabled);
        }
        private void UpdateUIBasedOnEnglish(bool isEnglishEnabled)
        {
            if (isEnglishEnabled == true)
            {
                btnChangeLan.Image = Properties.Resources._32_black_english;
                lblTextFace.Text = "Facebook helps you connect and share with the people in your life.";
                CtxtEmail.PlaceholderText = "Username";
                CtxtEmail.Texts = "";
                CtxtPassword.PlaceholderText = "Password";
                CtxtPassword.Texts = "";
                CbtnLogin.Text = "Login";
                CbtnRegister.Text = "Register";
                llblResetPassword.Text = "Forgot Password";
                this.Text = "Facebook - Login or Register";
            }
            else
            {
                btnChangeLan.Image = Properties.Resources._32_black_vietnam;
                lblTextFace.Text = "Facebook giúp bạn kết nối và chia sẻ với mọi người trong cuộc sống của bạn.";
                CtxtEmail.PlaceholderText = "Tên đăng nhập";
                CtxtEmail.Texts = "";
                CtxtPassword.PlaceholderText = "Mật khẩu";
                CtxtPassword.Texts = "";
                CbtnLogin.Text = "Đăng nhập";
                CbtnRegister.Text = "Tạo tài khoản mới";
                llblResetPassword.Text = "Quên mật khẩu";
                this.Text = "Facebook - Đăng nhập hoặc đăng ký";
            }
        }
        #endregion

        #region -> DarkMode
        private void DarkMode_OnDarkModeChanged(bool isDarkModeEnabled)
        {
            UpdateUIBasedOnDarkMode(isDarkModeEnabled);
        }
        //#ffffff #f6f7f8 #dcdcdc #f0f8ff #1877f2
        //#18191a #242526 #3a3b3c #1877f2 #ffffff
        private void UpdateUIBasedOnDarkMode(bool isDarkModeEnabled)
        {
            if (isDarkModeEnabled == true)
            {
                pnlContent.BackColor = ColorTranslator.FromHtml("#18191a");
                pnlLoginBox.BackColor = ColorTranslator.FromHtml("#242526");
                CtxtEmail.BackColor = ColorTranslator.FromHtml("#242526");
                CtxtPassword.BackColor = ColorTranslator.FromHtml("#242526");
                lblTextFace.ForeColor = ColorTranslator.FromHtml("#ffffff");
                CtxtEmail.ForeColor = ColorTranslator.FromHtml("#ffffff");
                CtxtPassword.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else
            {
                pnlContent.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                pnlLoginBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                CtxtEmail.BackColor = ColorTranslator.FromHtml("#ffffff");
                CtxtPassword.BackColor = ColorTranslator.FromHtml("#ffffff");
                lblTextFace.ForeColor = ColorTranslator.FromHtml("#000000");
                CtxtEmail.ForeColor = ColorTranslator.FromHtml("#000000");
                CtxtPassword.ForeColor = ColorTranslator.FromHtml("#000000");
            }    
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (DarkMode.IsDarkModeEnabled == false)
            {
                DarkMode.IsDarkModeEnabled = true;
            }
            else
            {
                DarkMode.IsDarkModeEnabled = false;
            }
        }
    }
}
