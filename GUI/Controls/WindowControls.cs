using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class WindowControls : UserControl
    {
        public event EventHandler CloseClicked;
        public event EventHandler MaximizeClicked;
        public event EventHandler MinimizeClicked;

        private Color currentCloseBackground;
        private Color currentBackground;


        public WindowControls()
        {
            InitializeComponent();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            CloseClicked?.Invoke(sender, e);
        }

        private void ptbMaximize_Click(object sender, EventArgs e)
        {
            MaximizeClicked?.Invoke(sender, e);
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            MinimizeClicked?.Invoke(sender, e);
        }

        private void pnlClose_Click(object sender, EventArgs e)
        {
            CloseClicked?.Invoke(sender, e);
        }

        private void pnlMaximize_Click(object sender, EventArgs e)
        {
            MaximizeClicked?.Invoke(sender, e);
        }

        private void pnlMinimize_Click(object sender, EventArgs e)
        {
            MinimizeClicked?.Invoke(sender, e);
        }

        //Hieu ung doi mau background cac nut
        private void pnlClose_MouseEnter(object sender, EventArgs e)
        {
            currentCloseBackground = pnlClose.BackColor = ptbClose.BackColor;
            pnlClose.BackColor = ptbClose.BackColor = Color.Red;
        }

        private void pnlClose_MouseLeave(object sender, EventArgs e)
        {
            pnlClose.BackColor = ptbClose.BackColor = currentCloseBackground;
        }

        private void pnlMaximize_MouseEnter(object sender, EventArgs e)
        {

            ChangeColor(pnlMaximize, ptbMaximize);
        }

        private void pnlMaximize_MouseLeave(object sender, EventArgs e)
        {
            pnlMaximize.BackColor = ptbMaximize.BackColor = currentBackground;
        }

        private void pnlMinimize_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(pnlMinimize, ptbMinimize);
        }

        private void pnlMinimize_MouseLeave(object sender, EventArgs e)
        {
            pnlMinimize.BackColor = ptbMinimize.BackColor = currentBackground;
        }
        private void ChangeColor(Control control1, Control control2)
        {
            currentBackground = control1.BackColor;
            control1.BackColor = Color.DarkGray;
            control2.BackColor = Color.DarkGray;
        }   

        private void ptbClose_MouseEnter(object sender, EventArgs e)
        {
            currentBackground = ptbClose.BackColor = pnlClose.BackColor;
            ptbClose.BackColor = pnlClose.BackColor = Color.Red;
        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.BackColor = pnlClose.BackColor = currentCloseBackground;
        }

        private void ptbMaximize_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(ptbMaximize, pnlMaximize);
        }

        private void ptbMaximize_MouseLeave(object sender, EventArgs e)
        {
            ptbMaximize.BackColor = pnlMaximize.BackColor = currentBackground;
        }

        private void ptbMinimize_MouseEnter(object sender, EventArgs e)
        {
            ChangeColor(ptbMinimize, pnlMinimize);
        }

        private void ptbMinimize_MouseLeave(object sender, EventArgs e)
        {
            ptbMinimize.BackColor = pnlMinimize.BackColor = currentBackground;
        }

    }
}