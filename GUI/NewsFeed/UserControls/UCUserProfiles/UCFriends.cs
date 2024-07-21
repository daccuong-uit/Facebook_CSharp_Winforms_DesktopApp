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
    public partial class UCFriends : UserControl
    {
        public UCFriends()
        {
            InitializeComponent();
        }
        public void content(Image image, string name)
        {
            pictureBox2.Image = image;
            label1.Text = name;
        }
    }
}
