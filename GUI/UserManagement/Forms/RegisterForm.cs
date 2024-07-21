using BLL.Services;
using DTO;
using GUI.AppSettings;
using GUI.Controls.ChatControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI.UserManagement.Forms
{
    public partial class RegisterForm : Form
    {
        private int _userLoggedIn;
        private int _isAdjust = 0;
        ContactService contactService;
        AuthenticationService authenticationService;
        private Routing routing;
        private bool IsDarkModeEnabled;
        private bool IsEnglishEnabled;
        private string avatar = "D:\\_HocKi6\\C#\\MyApp\\Facebook\\GUI\\Assets\\Images\\215_user_icon";
        public RegisterForm()
        {
            InitializeComponent();
            routing = new Routing();
            authenticationService = new AuthenticationService();
            contactService = new ContactService();

            //Darkmode
            IsDarkModeEnabled = DarkMode.IsDarkModeEnabled;
            UpdateUIBasedOnDarkMode(IsDarkModeEnabled);

            //Language
            IsEnglishEnabled = Language.IsEnglishEnabled;
            English_OnEnglishChanged(IsEnglishEnabled);
        }
        public RegisterForm(int userLoggedIn)
        {
            _userLoggedIn = userLoggedIn;
            _isAdjust = 1;
            InitializeComponent();
            routing = new Routing();
            authenticationService = new AuthenticationService();
            contactService = new ContactService();

            //Darkmode
            IsDarkModeEnabled = DarkMode.IsDarkModeEnabled;
            UpdateUIBasedOnDarkMode(IsDarkModeEnabled);

            //Language
            IsEnglishEnabled = Language.IsEnglishEnabled;
            English_OnEnglishChanged(IsEnglishEnabled);

            UserDto user = authenticationService.GetUserByUserId(userLoggedIn);
            string name = user.Name;
            CtxtName.Texts = name;
            string lastName = user.LastName;
            txtLastName.Texts = lastName;
            string userName = user.UserName;
            txtUerName.Texts = userName;
            txtUerName.Enabled = false;
            string email = user.Email;
            txtEmail.Texts = email;
            string phoneNumber = user.PhoneNumber;
            CtxtPhoneNumber.Texts = phoneNumber;

            avatar = user.Avatar;
            txtPass.Text = user.Password;
        }
        private void picGoBack_Click(object sender, EventArgs e)
        {
            if (_isAdjust == 0)
            {
                routing.ShowLoginForm(this);
            }
            else
            {
                this.Hide();
            }
        }

        private void CbtnRegister_Click(object sender, EventArgs e)
        {
            // Lấy thông tin đăng ký từ các trường dữ liệu
            string name = CtxtName.Texts;
            string lastName = txtLastName.Texts;
            string userName = txtUerName.Texts;
            string email = txtEmail.Texts;
            string phoneNumber = CtxtPhoneNumber.Texts;
            string passwordDefault = "1";
            
            bool result = ValidateRegistrationInfo(txtEmail.Texts, txtUerName.Texts, txtLastName.Texts);
            if (result == true)
            {
                pnlContent.Visible = false;
                pnlContentPass.Visible = true;
                // Tạo đối tượng User với thông tin người dùng
                UserDto userDto = new UserDto();
                userDto.Name = name;
                userDto.LastName = lastName;
                userDto.UserName = userName;
                userDto.Email = email;
                userDto.PhoneNumber = phoneNumber;
                userDto.Password = passwordDefault;
                userDto.Avatar = avatar;

                // Gọi hàm Register trong AuthenticationService
                authenticationService.Register(userDto);
                int userId = authenticationService.GetUserIdByEmail(email);
                int count = authenticationService.GetNumberOfUser();
                if (count > 1)
                {
                    for (int secondUserId = 1; secondUserId < count; secondUserId++)
                    {
                        contactService.AddContact(userId, secondUserId);
                        contactService.AddContact(secondUserId, userId);
                    }
                }    
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //gọi hàm ResetPassword
            string email = txtEmail.Texts;
            string rePass = txtPassConfirm.Text;
            string password = txtPass.Text;

            //Kiểm tra mật khẩu

            if (password.Length < 8)
            {
                pnlPass.BorderColor = Color.Red;
                if (IsEnglishEnabled)
                {
                    MessageBox.Show("Password need 8 word at least", "Inform");
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự", "Thông báo");
                }
                pnlPassConfirm.BorderColor = Color.LightGray;
                pnlPass.BorderColor = Color.LightGray;
                pnlContentPass.Visible = false;
                pnlContentImage.Visible = true;
                lblText2.Visible = false;
                if (IsEnglishEnabled)
                {
                    lblTitle.Text = "Update your avatar";
                }
                else
                {
                    lblTitle.Text = "Cập nhật ảnh đại diện";
                }
            }
            else if (rePass != password)
            {
                pnlPassConfirm.BorderColor = Color.Red;
                if (IsEnglishEnabled)
                {
                    MessageBox.Show("Password don't match", "Inform");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp!", "Thông báo");
                }
            }
            else
            {
                authenticationService.ResetPassword(email, rePass);
                pnlPassConfirm.BorderColor = Color.LightGray;
                pnlPass.BorderColor = Color.LightGray;
                pnlContentPass.Visible = false;
                pnlContentImage.Visible = true;
                lblText2.Visible = false;
                if (IsEnglishEnabled)
                {
                    lblTitle.Text = "Update your avater";
                }
                else
                {
                    lblTitle.Text = "Cập nhật ảnh đại diện";
                }
            }
        }
        //Xóa các nội dung ở các ô mật khẩu
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPassConfirm.Text = "";
        }
        private void btnKOImage_Click(object sender, EventArgs e)
        {
            //Đăng ký thành công mà chưa chọn Avatar, đóng Form đăng ký
            this.Close(); 
            if (_isAdjust == 0)
            {
                routing.ShowLoginForm(this);
            }
        }

        private void btnOKImage_Click(object sender, EventArgs e)
        {
            //Đăng ký thành công và đã chọn Avatar, cập nhật avatar vô database rồi đóng Form đăng ký
            //Hàm cập nhật avatar
            string email = txtEmail.Texts;
            int userId = authenticationService.GetUserIdByEmail(email);
            authenticationService.UpdateAvatar(userId, avatar);
            this.Close();
            if(_isAdjust == 0)
            {
                routing.ShowLoginForm(this);
            }
        }
        //Mở dialog chọn hình ảnh
        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(imagePath);
                picAvatar.Image = selectedImage;
                avatar = imagePath;
            }
        }

        //Kiểm tra thôn tin đăng ký
        bool ValidateRegistrationInfo(string email, string username, string lastName)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                txtEmail.BorderColor = Color.Red;
                picStarEmail.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                txtUerName.BorderColor = Color.Red;
                picStarUsename.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                txtLastName.BorderColor = Color.Red;
                picStarLastName.Visible = true;
                return false;
            }
            return true;
        }
        private void txtLastName_Click(object sender, EventArgs e)
        {
            txtLastName.BorderColor = Color.LightGray;
            picStarLastName.Visible = false;
        }

        private void txtUerName_Click(object sender, EventArgs e)
        {
            txtUerName.BorderColor = Color.LightGray;
            picStarUsename.Visible = false;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BorderColor = Color.LightGray;
            picStarEmail.Visible = false;
        }

        // Kiểm tra password
        private void txtPass_Click(object sender, EventArgs e)
        {
            pnlPass.BorderColor = Color.LightGray;
        }

        private void txtPassConfirm_Click(object sender, EventArgs e)
        {
            pnlPassConfirm.BorderColor = Color.LightGray;
        }

        private void picHidePass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                if(IsDarkModeEnabled)
                {
                    picHidePass.Image = Properties.Resources._32_black_eye;
                }
                else
                {
                    picHidePass.Image = Properties.Resources._32_black_eye;
                }
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                if (IsDarkModeEnabled)
                {
                    picHidePass.Image = Properties.Resources._32_blue_eye_close;
                }
                else
                {
                    picHidePass.Image = Properties.Resources._32_black_eye_close;
                }
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void picHidePassCon_Click(object sender, EventArgs e)
        {
            if (txtPassConfirm.UseSystemPasswordChar == true)
            {
                if (IsDarkModeEnabled)
                {
                    picHidePassCon.Image = Properties.Resources._32_black_eye;
                }
                else
                {
                    picHidePassCon.Image = Properties.Resources._32_black_eye;
                }
                txtPassConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                if (IsDarkModeEnabled)
                {
                    picHidePassCon.Image = Properties.Resources._32_blue_eye_close;
                }
                else
                {
                    picHidePassCon.Image = Properties.Resources._32_black_eye_close;
                }
                txtPassConfirm.UseSystemPasswordChar = true;
            }
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
                lblTitle.Text = "Register";
                lblText2.Text = "Quickly and easily";

                label4.Text = "First Name";
                label5.Text = "Last Name";
                label6.Text = "Username";
                label8.Text = "Phone number";
                label1.Text = "By clicking Sign Up, you agree to our Terms, Privacy Policy and Cookie Policy. You can receive our notifications via Email whenever.";
                CbtnRegister.Text = "Signup";

                lblCreatePassword.Text = "Password";
                label3.Text = "Verify password";
                label2.Text = "Password is a password with at least 8 characters including upper and lower case letters, numbers and special symbols.";
                btnReset.Text = "Try again";
                btnComplete.Text = "Complete";

                btnKOImage.Text = "Later";
                btnOKImage.Text = "OK";
            }
            else
            {
                lblTitle.Text = "Đăng ký";
                lblText2.Text = "Nhanh chóng và dễ dàng";

                label4.Text = "Họ";
                label5.Text = "Tên";
                label6.Text = "Tên đăng nhập";
                label8.Text = "Số điện thoại";
                label1.Text = "Bằng cách nhấp vào Đăng ký, bạn đồng ý với Điều khoản, Chính sách quyền riêng tư và Chính sách cookie của chúng tôi. Bạn có thể nhận được thông báo của chúng tôi qua Email \r\nbất kỳ lúc nào.";
                CbtnRegister.Text = "Đăng ký";

                lblCreatePassword.Text = "Tạo mật khẩu";
                label3.Text = "Xác nhận mật khẩu";
                label2.Text = "Mật khẩu là mật khẩu có ít nhất 8 ký tự bao gồm chữ hoa và thường, số và các ký hiệu đặc biệt.";
                btnReset.Text = "Đặt lại";
                btnComplete.Text = "Hoàn thành";

                btnKOImage.Text = "Để sau";
                btnOKImage.Text = "Xác nhận";
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
                this.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                lblTitle.ForeColor = ColorTranslator.FromHtml("#ffffff");
                lblText2.ForeColor = ColorTranslator.FromHtml("#ffffff");

                label4.ForeColor = ColorTranslator.FromHtml("#ffffff");
                label5.ForeColor = ColorTranslator.FromHtml("#ffffff");
                label6.ForeColor = ColorTranslator.FromHtml("#ffffff");
                label7.ForeColor = ColorTranslator.FromHtml("#ffffff");
                label8.ForeColor = ColorTranslator.FromHtml("#ffffff");
                label1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                CtxtName.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                txtLastName.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                txtUerName.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                txtEmail.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                CtxtPhoneNumber.BackColor = ColorTranslator.FromHtml("#3a3b3c");

                lblCreatePassword.ForeColor = ColorTranslator.FromHtml("#ffffff");
                label3.ForeColor = ColorTranslator.FromHtml("#ffffff");
                label2.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnReset.ForeColor = ColorTranslator.FromHtml("#ffffff");
                picHidePassCon.Image = Properties.Resources._32_blue_eye_close;
                picHidePass.Image = Properties.Resources._32_blue_eye_close;
                txtPass.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                txtPassConfirm.BackColor = ColorTranslator.FromHtml("#3a3b3c");

                btnKOImage.ForeColor = ColorTranslator.FromHtml("#ffffff");
                picGoBack.Image = Properties.Resources._24_white_close;
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#ffffff");
                lblTitle.ForeColor = ColorTranslator.FromHtml("#000000");
                lblText2.ForeColor = ColorTranslator.FromHtml("#000000");

                label4.ForeColor = ColorTranslator.FromHtml("#000000");
                label5.ForeColor = ColorTranslator.FromHtml("#000000");
                label6.ForeColor = ColorTranslator.FromHtml("#000000");
                label7.ForeColor = ColorTranslator.FromHtml("#000000");
                label8.ForeColor = ColorTranslator.FromHtml("#000000");
                label1.ForeColor = ColorTranslator.FromHtml("#000000");
                CtxtName.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtLastName.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtUerName.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtEmail.BackColor = ColorTranslator.FromHtml("#ffffff");
                CtxtPhoneNumber.BackColor = ColorTranslator.FromHtml("#ffffff");

                lblCreatePassword.ForeColor = ColorTranslator.FromHtml("#000000");
                label3.ForeColor = ColorTranslator.FromHtml("#000000");
                label2.ForeColor = ColorTranslator.FromHtml("#000000");
                btnReset.ForeColor = ColorTranslator.FromHtml("#000000");
                picHidePassCon.Image = Properties.Resources._32_black_eye_close;
                picHidePass.Image = Properties.Resources._32_black_eye_close;
                txtPass.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtPassConfirm.BackColor = ColorTranslator.FromHtml("#ffffff");

                btnKOImage.ForeColor = ColorTranslator.FromHtml("#000000");
                picGoBack.Image = Properties.Resources._24_black_close;
            }
        }
        #endregion
    }
}
