using AxMSVidCtlLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GUI.Controls.ChatControls
{
    public partial class VideoChatUsers : UserControl
    {
        public VideoChatUsers()
        {
            InitializeComponent();
        }
        public void content(Image image, string dateTime)
        {
            picAvatar.Image = image;
            lblTime.Text = dateTime;
        }
        public void DarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                this.BackColor = ColorTranslator.FromHtml("#242526");
                lblTime.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                lblTime.ForeColor = ColorTranslator.FromHtml("#000000");
            }
        }
    }
}
