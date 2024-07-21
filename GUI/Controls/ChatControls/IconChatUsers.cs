using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Controls.ChatControls
{
    public partial class IconChatUsers : UserControl
    {
        public IconChatUsers()
        {
            InitializeComponent();
        }
        public void content(Image image, Image i, string dateTime)
        {
            picAvatar.Image = image;
            picEmo.Image = i;
            lblTime.Text = dateTime;
        }
        public void DarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                this.BackColor = ColorTranslator.FromHtml("#242526");
                panel1.BackColor = ColorTranslator.FromHtml("#242526");
                lblTime.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                lblTime.ForeColor = ColorTranslator.FromHtml("#000000");
            }
        }
    }
}
