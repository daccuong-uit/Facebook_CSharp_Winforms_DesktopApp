using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Controls.StoreMediaControls
{
    public partial class ImageStore : UserControl
    {
        public ImageStore()
        {
            InitializeComponent();
        }
        public void content(Image i, string dateTime)
        {
            picImageMess.Image = i;
            
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
