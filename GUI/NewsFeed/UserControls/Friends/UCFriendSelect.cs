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
    public partial class UCFriendSelect : UserControl
    {
        private int _tick;
        private int _friendId;
        public UCFriendSelect()
        {
            InitializeComponent();
        }
        public void data(int friendId, int tick)
        {
            _friendId = friendId;
            _tick = tick;
        }

        public void content(Image avatar, string name, int tick)
        {
            picAvatar.Image = avatar;
            lblName.Text = name;
            if(tick == 0)
            {
                customePicture1.Image = Properties.Resources._32_dimgray_tick;
            }
            else
            {
                customePicture1.Image = Properties.Resources._32_blue_tick;
            }
        }

        public int GetFriendId()
        {
            return _friendId;
        } 

        public event EventHandler ButtonClicked;
        private void customePicture1_Click(object sender, EventArgs e)
        {
            if(customePicture1.Height == 32)
            {
                customePicture1.Image = Properties.Resources._32_blue_tick;
                customePicture1.Height = 33;
            }
            else
            {
                customePicture1.Image = Properties.Resources._32_dimgray_tick;
                customePicture1.Height = 32;
            }
            OnButtonClicked();
        }
        protected virtual void OnButtonClicked()
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
