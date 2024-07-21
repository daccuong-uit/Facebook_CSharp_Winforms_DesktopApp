using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NewsFeed.UserControls.Comments
{
    public partial class UCFriendAccept : UserControl
    {
        FriendsService friendsService;

        private int _requestId;
        private int _senderId;
        private int _receiverId;
        private int _status;
        public UCFriendAccept()
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
        public void content(Image avatar, string name, string banchung)
        {
            pictureBox1.Image = avatar;
            lblName.Text = name;
            lblBanChung.Text = banchung;
        }

        public event EventHandler Button2Clicked;
        private void customButton10_Click(object sender, EventArgs e)
        {
            _requestId = friendsService.GetRequestIdBySenderAndReceiver(_receiverId, _senderId);
            friendsService.AcceptFriendRequest(_requestId);
            OnButton2Clicked();
        }
        protected virtual void OnButton2Clicked()
        {
            Button2Clicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Button3Clicked;
        private void customButton1_Click(object sender, EventArgs e)
        {
            _requestId = friendsService.GetRequestIdBySenderAndReceiver(_senderId, _receiverId);
            friendsService.RejectFriendRequest(_requestId);
            OnButton3Clicked();
        }
        protected virtual void OnButton3Clicked()
        {
            Button3Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
