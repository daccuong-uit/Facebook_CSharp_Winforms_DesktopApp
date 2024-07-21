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
    public partial class ChatUsers : UserControl
    {
        public ChatUsers()
        {
            InitializeComponent();
        }
        public void Content(Image image, string s, string dateTime)
        {
            picAvatar.Image = image;
            txtText.Text = s;
            lblTime.Text = dateTime;
        }
        public RichTextBox GetTextBox()
        {
            RichTextBox textBox;
            textBox = txtText;
            return textBox;
        }
        public void SetControlSize(int width, int height)
        {
            Panel1.Width = width;
            Panel1.Height = height;
            txtText.Width = width - 15;
            txtText.Height = height -20;
        }
        public void DarkMode(bool isDarkMode)
        {
            if (isDarkMode)
            {
                this.BackColor = ColorTranslator.FromHtml("#242526");
                Panel1.BackColor = ColorTranslator.FromHtml("#242526");
                Panel1.BorderColor = ColorTranslator.FromHtml("#0a54b3");
                txtText.BackColor = ColorTranslator.FromHtml("#242526");
                txtText.ForeColor = ColorTranslator.FromHtml("#ffffff");
                lblTime.ForeColor = ColorTranslator.FromHtml("#ffffff");
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                Panel1.BackColor = ColorTranslator.FromHtml("#ffffff");
                Panel1.BorderColor = ColorTranslator.FromHtml("#1877f2");
                txtText.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtText.ForeColor = ColorTranslator.FromHtml("#000000");
                lblTime.ForeColor = ColorTranslator.FromHtml("#000000");
            }    
        }
    }
}
