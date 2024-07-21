using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using GUI.NewsFeed.Forms;
using GUI.AppSettings;
using GUI.Messaging.Forms;

namespace GUI.UserManagement.Forms
{
    public partial class ForgotPassword : BaseFormLogin
    {
        private Routing routing;
        AuthenticationService authenticationService;
        private string OTP;
        public ForgotPassword()
        {
            InitializeComponent();
            routing = new Routing();
            authenticationService = new AuthenticationService();

            //Darkmode
            UpdateUIBasedOnDarkMode(DarkMode.IsDarkModeEnabled);

            //Language
            English_OnEnglishChanged(Language.IsEnglishEnabled);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            routing.ShowLoginForm(this);
            // Cập nhật lại mật khẩu ở đây
        }

        private void CbtnLogin_Click(object sender, EventArgs e)
        {
            string username = CtxtEmail.Texts;
            string password = CtxtPassword.Texts;

            int loginSuccessful = authenticationService.Login(username, password);

            if (loginSuccessful != 0)
            {
                //MainForm mainForm = new MainForm();
                //mainForm.Show();
                ChatForm chatForm = new ChatForm();
                chatForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed.");
            }
        }

        private void btnGetOTP_Click(object sender, EventArgs e)
        {
            string strEmail = CtxtEnterEmail.Texts;
            if (strEmail == null)
            {
                MessageBox.Show("Vui lòng nhập email");
            }
            else
            {
                OTP = authenticationService.SendEmail(strEmail);

                pnlResetBoxStep1.Visible = false;
                pnlResetPasswordStep2.Visible = true;
            }    
        }

        private void btnNexttoReset_Click(object sender, EventArgs e)
        {
            string userOTP = txtOTP.Texts;
            if (userOTP == OTP)
            {
                pnlResetPasswordStep2.Visible = false;
                pnlResetPassword3.Visible = true;
            }
            else
            {
                txtOTP.Texts = "";
                MessageBox.Show("Mã OTP không khớp! Vui lòng nhập lại.");
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlResetBoxStep1.Visible = true;
            pnlResetPasswordStep2.Visible = false;
            pnlResetPassword3.Visible = false;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //Hàm kiểm tra
            if(txtNewPass.Texts == txtNewPassConfirm.Texts)
            {
                string email = CtxtEnterEmail.Texts;
                string newPass = txtNewPass.Texts;
                authenticationService.ResetPassword(email, newPass);

                routing.ShowLoginForm(this);
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo");
            }    
        }

        private void btnSendEmailAgain_Click(object sender, EventArgs e)
        {
            string strEmail = CtxtEnterEmail.Texts;

            OTP = authenticationService.SendEmail(strEmail);

            pnlResetBoxStep1.Visible = false;
            pnlResetPasswordStep2.Visible = true;
        }

        private void picGoBack_Click(object sender, EventArgs e)
        {
            routing.ShowLoginForm(this);
        }

        private void pnlGoBack_Click(object sender, EventArgs e)
        {
            routing.ShowLoginForm(this);
        }

        #region -> Language
        private void English_OnEnglishChanged(bool isEnglishEnabled)
        {
            UpdateUIBasedOnEnglish(isEnglishEnabled);
        }
        private void UpdateUIBasedOnEnglish(bool isEnglishEnabled)
        {
            if (isEnglishEnabled == true)
            {
                CtxtEmail.PlaceholderText = "Email or Usernam";
                CtxtEmail.Texts = "";
                CtxtPassword.PlaceholderText = "Password";
                CtxtPassword.Texts = "";
                CbtnLogin.Text = "Login";
                llblResetPassword.Text = "Forgot Email";

                lnlTextStep2.Text = "Get your password";
                lblTextOTP.Text = "Please enter your OTP";
                CtxtEnterEmail.PlaceholderText = "Enter your Email";
                CtxtEnterEmail.Texts = "";

                txtOTP.PlaceholderText = "Enter OTP";
                txtOTP.Texts = "";
                btnSendEmailAgain.Text = "Resend";
                btnNexttoReset.Text = "Next";

                lblText1.Text = "Get your password";
                lblText2.Text = "Please enter your Email to get OTP";
                btnCancel.Text = "Cancel";
                btnGetOTP.Text = "Get OTP";
                lblResetPassword3.Text = "Get your password";
                txtNewPass.PlaceholderText = "Enter new password";
                txtNewPass.Texts = "";
                txtNewPassConfirm.PlaceholderText = "Verify your password";
                txtNewPassConfirm.Texts = "";
                btnCancel2.Text = "Cancel";
                btnComplete.Text = "Complete";
            }
            else
            {
                CtxtEmail.PlaceholderText = "Email hoặc tên tài khoản";
                CtxtEmail.Texts = "";
                CtxtPassword.Texts = "";
                CtxtPassword.PlaceholderText = "Mật khẩu";
                CbtnLogin.Text = "Đăng nhập";
                llblResetPassword.Text = "Bạn quên email ư?";
                lnlTextStep2.Text = "Lấy lại mật khẩu của bạn";
                lblTextOTP.Text = "Vui lòng nhập mã OTP";
                txtOTP.Texts = "";
                txtOTP.PlaceholderText = "Nhập mã OTP";
                btnSendEmailAgain.Text = "Gửi lại";
                btnNexttoReset.Text = "Tiếp tục";
                lblText1.Text = "Lấy lại mật khẩu của bạn";
                lblText2.Text = "Vui lòng nhập email để nhận mã OTP";
                CtxtEnterEmail.PlaceholderText = "Nhập email";
                CtxtEnterEmail.Texts = "";
                btnCancel.Text = "Hủy";
                btnGetOTP.Text = "Lấy mã";
                lblResetPassword3.Text = "Lấy lại mật khẩu của bạn";
                txtNewPass.PlaceholderText = "Nhập mật khẩu mới";
                txtNewPass.Texts = "";
                txtNewPassConfirm.PlaceholderText = "Xác nhận mật khẩu";
                txtNewPassConfirm.Texts = "";
                btnCancel2.Text = "Hủy";
                btnComplete.Text = "Hoàn thành";
            }
        }
        #endregion

        #region -> DarkMode
        private void btnDarkMode_Click(object sender, EventArgs e)
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
        //#ffffff #f6f7f8 #dcdcdc #f0f8ff #1877f2
        //#18191a #242526 #3a3b3c #1877f2 #ffffff
        private void UpdateUIBasedOnDarkMode(bool isDarkModeEnabled)
        {
            if (isDarkModeEnabled == true)
            {
                pnlContent.BackColor = ColorTranslator.FromHtml("#242526");

                pnlLogin.BackColor = ColorTranslator.FromHtml("#18191a");
                CtxtEmail.BackColor = ColorTranslator.FromHtml("#18191a");
                CtxtPassword.BackColor = ColorTranslator.FromHtml("#18191a");
                CtxtEmail.ForeColor = ColorTranslator.FromHtml("#ffffff");
                CtxtPassword.ForeColor = ColorTranslator.FromHtml("#ffffff");

                txtNewPass.BackColor = ColorTranslator.FromHtml("#18191a");
                txtNewPassConfirm.BackColor = ColorTranslator.FromHtml("#18191a");
                txtNewPass.ForeColor = ColorTranslator.FromHtml("#ffffff");
                txtNewPassConfirm.ForeColor = ColorTranslator.FromHtml("#ffffff");
                pnlResetPassword3.BackColor = ColorTranslator.FromHtml("#18191a");
                btnCancel2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnCancel2.BackColor = ColorTranslator.FromHtml("#3a3b3c");

                pnlResetPasswordStep2.BackColor = ColorTranslator.FromHtml("#18191a");
                lnlTextStep2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                lblTextOTP.ForeColor = ColorTranslator.FromHtml("#ffffff");
                txtOTP.BackColor = ColorTranslator.FromHtml("#18191a");
                txtOTP.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnSendEmailAgain.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnSendEmailAgain.BackColor = ColorTranslator.FromHtml("#3a3b3c");

                lblResetPassword3.ForeColor = ColorTranslator.FromHtml("#ffffff");
                pnlResetBoxStep1.BackColor = ColorTranslator.FromHtml("#18191a");
                lblText1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                lblText2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                CtxtEnterEmail.BackColor = ColorTranslator.FromHtml("#18191a");
                CtxtEnterEmail.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnCancel.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnCancel.BackColor = ColorTranslator.FromHtml("#3a3b3c");
            }
            else
            {
                pnlContent.BackColor = ColorTranslator.FromHtml("#f6f7f8");

                pnlLogin.BackColor = ColorTranslator.FromHtml("#ffffff");
                CtxtEmail.BackColor = ColorTranslator.FromHtml("#ffffff");
                CtxtPassword.BackColor = ColorTranslator.FromHtml("#ffffff");
                CtxtEmail.ForeColor = ColorTranslator.FromHtml("#000000");
                CtxtPassword.ForeColor = ColorTranslator.FromHtml("#000000");

                txtNewPass.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtNewPassConfirm.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtNewPass.ForeColor = ColorTranslator.FromHtml("#000000");
                txtNewPassConfirm.ForeColor = ColorTranslator.FromHtml("#000000");
                pnlResetPassword3.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnCancel2.ForeColor = ColorTranslator.FromHtml("#000000");
                btnCancel2.BackColor = ColorTranslator.FromHtml("#dcdcdc");

                pnlResetPasswordStep2.BackColor = ColorTranslator.FromHtml("#ffffff");
                lnlTextStep2.ForeColor = ColorTranslator.FromHtml("#000000");
                lblTextOTP.ForeColor = ColorTranslator.FromHtml("#000000");
                txtOTP.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtOTP.ForeColor = ColorTranslator.FromHtml("#000000");
                btnSendEmailAgain.ForeColor = ColorTranslator.FromHtml("#000000");
                btnSendEmailAgain.BackColor = ColorTranslator.FromHtml("#dcdcdc");

                lblResetPassword3.ForeColor = ColorTranslator.FromHtml("#000000");
                lblText1.ForeColor = ColorTranslator.FromHtml("#000000");
                lblText2.ForeColor = ColorTranslator.FromHtml("#000000");
                CtxtEnterEmail.BackColor = ColorTranslator.FromHtml("#ffffff");
                CtxtEnterEmail.ForeColor = ColorTranslator.FromHtml("000000");
                btnCancel.ForeColor = ColorTranslator.FromHtml("#000000");
                btnCancel.BackColor = ColorTranslator.FromHtml("#dcdcdc");
            }
        }
        #endregion
    }
}
