using BLL.Services;
using DTO;
using DTO.Main;
using GUI.NewsFeed.UserControls.Comments;
using GUI.NewsFeed.UserControls.UCUserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NewsFeed.UserControls.Friends
{
    public partial class UCFriendsForm : UserControl
    {
        private UCSuggestFriend ucSuggestFriend;
        private UCFriendAccept ucFriendAccept;

        FriendsService friendsService = new FriendsService();
        AuthenticationService authenticationService = new AuthenticationService();

        public List<FriendRequestDto> friends = new List<FriendRequestDto>();
        public List<FriendRequestDto> listFriends = new List<FriendRequestDto>();
        public List<int> listUserId = new List<int>();
        public List<int> listFriendUserId = new List<int>();
        public List<int> listNonFriendUserId = new List<int>();

        private int sessionId;
        private int userIdLogin;

        private int _requestId;

        public UCFriendsForm()
        {
            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);

            InitializeComponent();
            LoadPendingFriend();
            LoadSuggestFriend();
            LoadAllFriend();

            //Suggets friends
            ucSuggestFriend = new UCSuggestFriend();
            //Accept friends
            ucFriendAccept = new UCFriendAccept();

            btnHome.BackColor = Color.Gainsboro;
        }

        #region -> Load data
        private void GetPendingFriend()
        {
            //Get pending friends
            friends = friendsService.GetPendingFriendRequests(userIdLogin);
        }
        private void GetSuggestFriend()
        {
            //Get friends
            listFriendUserId = friendsService.GetFriendsIds(userIdLogin);
            listUserId = authenticationService.GetAllUserIds();
            listNonFriendUserId = listUserId.Except(listFriendUserId).ToList();
        }
        private void GetAllFriend()
        {
            listFriends = friendsService.GetFriendsList(userIdLogin);
        }
        private void LoadPendingFriend()
        {
            GetPendingFriend();
            flpFriends.Controls.Clear();

            foreach (var friend in friends)
            {
                UserDto userFriend;
                //Get speding friends
                if (friend.SenderId == userIdLogin)
                {
                    userFriend = authenticationService.GetUserByUserId(friend.ReceiverId);
                }
                else
                {
                    userFriend = authenticationService.GetUserByUserId(friend.SenderId);
                }

                string friendName = userFriend.Name + " " + userFriend.LastName;
                Image friendAvatar = Image.FromFile(userFriend.Avatar);

                string relativeTime = GetRelativeTime(friend.SendAt);
                //end

                UCFriendAccept Friend = new UCFriendAccept();
                Friend.data(userIdLogin, userFriend.UserId, 0);
                Friend.content(friendAvatar, friendName, relativeTime);
                Friend.Button2Clicked += FriendAccept_Button2Clicked;
                Friend.Button3Clicked += FriendAccept_Button3Clicked;
                flpFriends.Controls.Add(Friend);
            }
        }
        private void FriendAccept_Button2Clicked(object sender, EventArgs e)
        {
            UCFriendAccept clickedUserControl = (UCFriendAccept)sender;
            flpFriends.Controls.Remove(clickedUserControl);
        }
        private void FriendAccept_Button3Clicked(object sender, EventArgs e)
        {
            UCFriendAccept clickedUserControl = (UCFriendAccept)sender;
            flpFriends.Controls.Remove(clickedUserControl);
        }
        string GetRelativeTime(DateTime sendAt)
        {
            TimeSpan timeSpan = DateTime.Now - sendAt;

            if (timeSpan.TotalSeconds < 60)
            {
                return "Vừa xong";
            }
            else if (timeSpan.TotalMinutes < 60)
            {
                return $"{(int)timeSpan.TotalMinutes} phút trước";
            }
            else if (timeSpan.TotalHours < 24)
            {
                return $"{(int)timeSpan.TotalHours} giờ trước";
            }
            else if (timeSpan.TotalDays < 7)
            {
                return $"{(int)timeSpan.TotalDays} ngày trước";
            }
            else
            {
                return sendAt.ToString("dd/MM/yyyy");
            }
        }
        private void LoadSuggestFriend()
        {
            GetSuggestFriend();
            flpFriendSuggest.Controls.Clear();

            foreach (var userId in listNonFriendUserId)
            {
                if (userId == userIdLogin)
                {
                    continue;
                }
                UserDto userFriend;
                
                userFriend = authenticationService.GetUserByUserId(userId);

                string name = userFriend.Name;
                string lastName = userFriend.LastName;
                Image friendAvatar = Image.FromFile(userFriend.Avatar);
                //end

                UCSuggestFriend suggestFriend = new UCSuggestFriend();
                suggestFriend.data(userIdLogin, userFriend.UserId, 0);
                suggestFriend.content(friendAvatar, lastName, name, "0"); 
                suggestFriend.ButtonClicked += SuggestFriend_ButtonClicked;
                flpFriendSuggest.Controls.Add(suggestFriend);
            }
        }
        private void SuggestFriend_ButtonClicked(object sender, EventArgs e)
        {
            UCSuggestFriend clickedUserControl = (UCSuggestFriend)sender;
            flpFriendSuggest.Controls.Remove(clickedUserControl);
        }

        private void LoadAllFriend()
        {
            GetAllFriend();
            flpAllFriends.Controls.Clear();

            foreach (var friend in listFriends)
            {
                UserDto userFriend;
                if(friend.SenderId == userIdLogin)
                {
                    userFriend = authenticationService.GetUserByUserId(friend.ReceiverId);
                }
                else
                {
                    userFriend = authenticationService.GetUserByUserId(friend.SenderId);
                }

                string name = userFriend.Name + " " + userFriend.LastName;
                Image friendAvatar = Image.FromFile(userFriend.Avatar);
                //end

                UCFriendUI ucFriendUI = new UCFriendUI();
                ucFriendUI.data(userIdLogin, userFriend.UserId, friend.Status);
                ucFriendUI.content(friendAvatar, name, 1);
                ucFriendUI.ButtonClicked += AllFriend_ButtonClicked;
                ucFriendUI.ButtonClicked1 += AllFriend1_ButtonClicked;
                flpAllFriends.Controls.Add(ucFriendUI);
            }
        }
        private void AllFriend_ButtonClicked(object sender, EventArgs e)
        {
            UCFriendUI clickedUserControl = (UCFriendUI)sender;
            flpAllFriends.Controls.Remove(clickedUserControl);
        }
        public event EventHandler<UserClickedEventArgs> ssClicked;
        private void AllFriend1_ButtonClicked(object sender, EventArgs e)
        {
            UCFriendUI clickedUserControl = (UCFriendUI)sender;
            int id = clickedUserControl.GetCLickId();
            OnssClicked(id);
        }
        public class UserClickedEventArgs : EventArgs
        {
            public int UserId { get; }

            public UserClickedEventArgs(int userId)
            {
                UserId = userId;
            }
        }
        protected virtual void OnssClicked(int userId)
        {
            ssClicked?.Invoke(this, new UserClickedEventArgs(userId));
        }

        #endregion

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Gainsboro;
            flpContent.Visible = true;
            flpAllFriends.Visible = false;
            lblAllFriends.Visible = false;
        }

        private void btnSavedVideo_Click(object sender, EventArgs e)
        {
            btnSavedVideo.BackColor = Color.Gainsboro;
            flpContent.Visible = false;
            flpAllFriends.Visible = true;
            lblAllFriends.Visible = true;
        }
    }
}
