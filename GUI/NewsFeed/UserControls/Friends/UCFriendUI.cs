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
    public partial class UCFriendUI : UserControl
    {
        FriendsService friendsService;

        private int _requestId;
        private int _senderId;
        private int _receiverId;
        private int _status;
        public UCFriendUI()
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
        public void content(Image avatar, string name, int isFriend)
        {
            pictureBox1.Image = avatar;
            lblName.Text = name;
            
            if(isFriend == 0)
            {
                btnDecline.Text = "Thêm bạn bè";
            }
        }
        public int GetCLickId()
        {
            return _receiverId;
        }

        public event EventHandler ButtonClicked;
        public event EventHandler ButtonClicked1;
        private void btnDecline_Click(object sender, EventArgs e)
        {
            OnButtonClicked();
        }
        protected virtual void OnButtonClicked()
        {
            if(btnDecline.Text == "Thêm bạn bè")
            {
                _requestId = friendsService.GetRequestIdBySenderAndReceiver(_senderId, _receiverId);
                btnDecline.Text = "Huỷ lời mời";
                friendsService.SendFriendRequest(_senderId, _receiverId);
            }
            else
            {
                if(btnSendRequest.Text == "Huỷ lời mời")
                {
                    _requestId = friendsService.GetRequestIdBySenderAndReceiver(_senderId, _receiverId);
                    btnDecline.Text = "Thêm bạn bè";
                    friendsService.RejectFriendRequest(_requestId);
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa bạn bè này?", "Xác nhận xóa bạn bè", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        friendsService.DeleteFriend(_senderId, _receiverId);
                        btnDecline.Text = "Thêm bạn bè";
                    }
                }
            }
            
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            OnButtonClicked1();
        }
        protected virtual void OnButtonClicked1()
        {
            ButtonClicked1?.Invoke(this, EventArgs.Empty);
        }
    }
}
