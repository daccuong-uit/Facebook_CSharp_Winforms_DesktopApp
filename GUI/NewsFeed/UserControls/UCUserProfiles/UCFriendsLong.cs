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
    public partial class UCFriendsLong : UserControl
    {
        private int _userFriendId;
        public UCFriendsLong()
        {
            InitializeComponent();
        }
        public void data(int userFriendId)
        {
            _userFriendId = userFriendId;
        }
        public void content(Image image, string name)
        {
            picAvatar.Image = image;
            lblName.Text = name;
        }
        public int GetUserFriendId()
        {
            return _userFriendId;
        }
        public event EventHandler Button111Clicked;

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OnButton111Clicked();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            OnButton111Clicked();
        }
        protected virtual void OnButton111Clicked()
        {
            Button111Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
