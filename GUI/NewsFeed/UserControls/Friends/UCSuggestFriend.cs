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
    public partial class UCSuggestFriend : UserControl
    {
        FriendsService friendsService;

        private int _requestId;
        private int _senderId;
        private int _receiverId;
        private int _status;
        public UCSuggestFriend()
        {
            InitializeComponent();
            friendsService = new FriendsService();
        }

        public void data(int sendererId, int receiverId, int status)
        {
            _senderId = sendererId;
            _receiverId = receiverId;
            _status = status;
        }
        public void content(Image avatar, string name, string lastName, string banchung)
        {
            pictureBox1.Image = avatar;
            lblName.Text = lastName + " " + name;
            lblBanChung.Text = banchung;
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
                btnSendRequest.Text = "Thêm bạn bè";
                friendsService.RejectFriendRequest(_requestId);
            }
        }

        public event EventHandler ButtonClicked;
        private void btnDecline_Click(object sender, EventArgs e)
        {
            OnButtonClicked();
        }
        protected virtual void OnButtonClicked()
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
