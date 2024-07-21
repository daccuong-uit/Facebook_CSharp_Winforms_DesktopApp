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
    public partial class UCComments : UserControl
    {
        public UCComments()
        {
            InitializeComponent();
        }
        private void Design()
        {
            int height = lblCmt.Height + 35;
            border.Height = height;
            int width;
            int a = lblName.Width + 55;
            int b = lblCmt.Width + 55;
            if (a > b)
            {
                width = a - 50;
            }
            else
            {
                width = b - 50;
            }
            border.Width = width;
            flowLayoutPanel1.Width = 590 - width - 25;
        }
        public void content(Image avatar, string name, string cmt)
        {
            picAvatar.Image = avatar;
            lblName.Text = name;
            lblCmt.Text = cmt;
            Design();
        }
    }
}
