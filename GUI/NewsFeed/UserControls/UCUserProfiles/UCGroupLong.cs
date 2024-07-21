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
    public partial class UCGroupLong : UserControl
    {
        public UCGroupLong()
        {
            InitializeComponent();
        }
        public void content(Image image, string name)
        {
            picAvatar.Image = image;
            lblName.Text = name;
        }
    }
}
