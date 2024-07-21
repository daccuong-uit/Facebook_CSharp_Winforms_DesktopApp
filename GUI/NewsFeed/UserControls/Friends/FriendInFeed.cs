using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NewsFeed.UserControls.Friends
{
    public partial class FriendInFeed : UserControl
    {
        FriendsService friendsService;

        private int _requestId;
        private int _senderId;
        private int _receiverId;
        private List<int> _ListFriend = new List<int>();
        public FriendInFeed()
        {
            InitializeComponent();

            friendsService = new FriendsService(); 
        }
        
        public void data(int sendererId, int receiverId)
        {
            _senderId = sendererId;
            _receiverId = receiverId;
            _ListFriend = friendsService.GetFriendsIds(_senderId);
            if (_ListFriend.Contains(_receiverId))
            {
                btnSendRequest.Text = "Xem trang cá nhân";
            }
        }
        public void content(Image avatar, string name)
        {
            picAvatar.Image = avatar;
            lblName.Text = name;
        }
        public int GetUserLike()
        {
            return _receiverId;
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            _requestId = friendsService.GetRequestIdBySenderAndReceiver(_senderId, _receiverId);

            if (btnSendRequest.Text == "Thêm bạn bè")
            {
                btnSendRequest.Text = "Huỷ lời mời";
                friendsService.SendFriendRequest(_senderId, _receiverId);
            }
            else
            {
                if (btnSendRequest.Text == "Huỷ lời mời")
                {
                    btnSendRequest.Text = "Thêm bạn bè";
                    friendsService.RejectFriendRequest(_requestId);
                }
                else
                {
                    OnButtonClicked();
                }
            }
        }
        public event EventHandler ButtonClicked;
        private void lblName_Click(object sender, EventArgs e)
        {
            OnButtonClicked();
        }
        protected virtual void OnButtonClicked()
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
