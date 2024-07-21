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

namespace GUI.Controls.StoreMediaControls
{
    public partial class VideoStore : UserControl
    {
        public VideoStore()
        {
            InitializeComponent();
        }
        public void content(string dateTime, string URL)
        {
            lblTime.Text = dateTime;
            axWindowsMediaPlayer1.URL = URL;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
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
