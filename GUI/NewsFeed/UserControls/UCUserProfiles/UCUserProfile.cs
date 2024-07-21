using BLL.Services;
using DTO;
using DTO.Main;
using GUI.Controls;
using GUI.UserManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NewsFeed.UserControls.UCUserProfiles
{
    public partial class UCUserProfile : UserControl
    {
        AuthenticationService authenticationService = new AuthenticationService();
        FriendsService friendsService = new FriendsService();

        private int sessionId;
        private int userIdLogin;
        UserDto user = new UserDto();
        List<int> friendIds = new List<int>();

        public UCUserProfile()
        {
            InitializeComponent();

            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);

            UCPost_PF ucPost_PF1 = new UCPost_PF(userIdLogin);
            pnlContent.Controls.Add(ucPost_PF1);

            LoadUser();
        }
        public UCUserProfile(int user)
        {
            InitializeComponent();

            userIdLogin = user;
            //sessionId = SessionManager.GetSessionId();
            //userIdLogin = SessionManager.GetuUserId(sessionId);
            UCPost_PF ucPost_PF1 = new UCPost_PF(userIdLogin);
            pnlContent.Controls.Add(ucPost_PF1);

            LoadUser();
        }

        private void GetUser()
        {
            user = authenticationService.GetUserByUserId(userIdLogin);
        }
        private void GetFriends()
        {
            friendIds = friendsService.GetFriendsIds(userIdLogin);
        }
        private void LoadUser()
        {
            GetUser(); 
            GetFriends();

            picAvatar.Image = Image.FromFile(user.Avatar);
            lblUserName.Text = user.Name + " " + user.LastName;
            int numFriends = friendIds.Count();
            lblNumberOfFriends.Text = numFriends + " bạn bè";
            flpFriendOnTop.Controls.Clear();
            foreach (var id in friendIds)
            {
                UserDto user = authenticationService.GetUserByUserId(id);
                Image avatar = Image.FromFile(user.Avatar);
                CustomePicture pic = new CustomePicture();
                pic.Size = new Size(30, 30);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Image = avatar;
                flpFriendOnTop.Controls.Add(pic);
            }
        }



        public void DesignFriendProfile(bool isFriend)
        {
            if(isFriend == true)
            {
                btnAdjustProfile.Image = Properties.Resources._24_gray_friends;
                btnAdjustProfile.Text = "     Bạn bè";
            }
            else
            {
                btnAdjustProfile.Image = Properties.Resources._24_gray_friends;
                btnAdjustProfile.Text = "     Thêm bạn bè";
            }
        }
        public void DesignUerProfile()
        {
                btnAdjustProfile.Image = Properties.Resources._32_dimgray_pen;
                btnAdjustProfile.Text = "     Chỉnh sửa profile";
        }

        #region -> Design
        // Design Background Image
        private void DesignBackgroundImage()
        {
            Image originalImage = Properties.Resources.avatar;

            int originalWidth = originalImage.Width;
            int originalHeight = originalImage.Height;

            int newWidth = 1080;
            int newHeight = 350;

            int x = (originalWidth - newWidth) / 2;
            int y = (originalHeight - newHeight) / 2;

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(originalImage, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(x, y, newWidth, newHeight), GraphicsUnit.Pixel);
            }
            picBackgroundAvatar.Image = newImage;
        }
        //end

        // Design navigate
        private void DesignNavigate(Control button)
        {
            lineNavigate.Width = button.Width;
            if (button.Tag.ToString() == "1")
            {
                lineNavigate.Location = new Point(128, 581);
            }
            if (button.Tag.ToString() == "3")
            {
                lineNavigate.Location = new Point(293, 581);
            }
            if (button.Tag.ToString() == "4")
            {
                lineNavigate.Location = new Point(362, 581);
            }
            if (button.Tag.ToString() == "5")
            {
                lineNavigate.Location = new Point(422, 581);
            }
        }
        //end
        #endregion

        private void btnPosst_Click(object sender, EventArgs e)
        {
            DesignNavigate(btnPosst);
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            DesignNavigate(btnFriends);
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            DesignNavigate(btnPhotos);
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            DesignNavigate(btnVideos);
        }

        private void btnAdjustProfile_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(userIdLogin);
            registerForm.ShowDialog();
        }
    }
}
