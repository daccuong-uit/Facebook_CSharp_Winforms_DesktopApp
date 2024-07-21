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
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }
        public int userID;
        public void LoadDataUser(int ID, string name, string lastName, string text, Image avatar)
        {
            userID = ID;
            lblUserName.Text = name + " " + lastName;
            lblLastMess.Text = text;
            picAvatar.Image = avatar;
        }
        public void DarkMode(bool isDarkMoed)
        {
            if (isDarkMoed)
            {
                this.BackColor = Color.Transparent;
                lblUserName.ForeColor = ColorTranslator.FromHtml("#ffffff");
                lblLastMess.ForeColor = ColorTranslator.FromHtml("#aaaaaa");
            }
            else
            {
                this.BackColor = Color.Transparent;
                lblUserName.ForeColor = ColorTranslator.FromHtml("#000000");
                lblLastMess.ForeColor = ColorTranslator.FromHtml("#808080");
            }
        }
    }
}
