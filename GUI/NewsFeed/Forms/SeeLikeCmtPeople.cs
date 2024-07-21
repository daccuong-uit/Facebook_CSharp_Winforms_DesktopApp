using BLL.Services;
using BLL.Services.Main;
using DAL.Models.Main;
using DTO;
using GUI.NewsFeed.UserControls.Comments;
using GUI.NewsFeed.UserControls.Friends;
using GUI.NewsFeed.UserControls.UCUserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NewsFeed.Forms
{
    public partial class SeeLikeCmtPeople : Form
    {
        private MainForm mainForm;
        LikeLoveService likeLoveService = new LikeLoveService();
        AuthenticationService authenticationService = new AuthenticationService();
        UCUserProfile ucUserProfile;

        public List<LikeLoveDto> likeLoveDtos = new List<LikeLoveDto>();

        private int _postId;

        private int sessionId;
        private int userIdLogin;
        public SeeLikeCmtPeople()
        {
            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);
            mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            InitializeComponent();
            LoadListFriendLike(); 
        }
        public SeeLikeCmtPeople(int postId)
        {
            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId); 
            mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            InitializeComponent();
            _postId = postId;
            LoadListFriendLike();

        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void GetLikeFriend(int postId)
        {
            likeLoveDtos = likeLoveService.GetLikeLoveByPostId(postId);
        }

        private void LoadListFriendLike()
        {
            GetLikeFriend(_postId);
            flowLayoutPanel1.Controls.Clear();

            foreach (var likeLoveDto in likeLoveDtos)
            {
                int userLikeId = likeLoveDto.UserLikeId;
                if(userIdLogin == userLikeId)
                {
                    continue;
                }
                UserDto userLikeFriend;

                userLikeFriend = authenticationService.GetUserByUserId(userLikeId);

                string name = userLikeFriend.Name + " " + userLikeFriend.LastName;
                Image friendAvatar = Image.FromFile(userLikeFriend.Avatar);
                //end

                FriendInFeed friendinFeed = new FriendInFeed();
                friendinFeed.data(userIdLogin, userLikeId);
                friendinFeed.content(friendAvatar, name);
                friendinFeed.ButtonClicked += LikeFriend_ButtonClicked;
                flowLayoutPanel1.Controls.Add(friendinFeed);
            }
        }
        private MainForm _mainForm;
        private void LikeFriend_ButtonClicked(object sender, EventArgs e)
        {
            FriendInFeed clickedUserControl = (FriendInFeed)sender;
            int id = clickedUserControl.GetUserLike();

            ucUserProfile = new UCUserProfile(id);

            mainForm.SeeLikeCmtPeople(ucUserProfile);

            this.Hide();
        }

    }
}
