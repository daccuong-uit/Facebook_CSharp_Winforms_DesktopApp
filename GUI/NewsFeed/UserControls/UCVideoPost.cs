using AxWMPLib;
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

namespace GUI.NewsFeed.UserControls.UCUserProfiles
{
    public partial class UCVideoPost : UserControl
    {
        public UCVideoPost()
        {
            InitializeComponent();
        }
        public void content(Image avatar, string name, string time, string caption, string videoPath, Image emo, string like, string cmt)
        {
            picAvatar.Image = avatar;
            lblName.Text = name;
            lblTime.Text = time;
            lblCaption.Text = caption;
            picEmo.Image = emo;
            lblNumberofLike.Text = like;
            lblNumberofCmt.Text = cmt;
            PlayVideo(videoPath);
        }
        public void PlayVideo(string videoPath)
        {
            try
            {
                AxWindowsMediaPlayer mediaPlayer = new AxWindowsMediaPlayer();

                mediaPlayer.URL = videoPath;

                mediaPlayer.Visible = true;

                mediaPlayer.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi phát video: " + ex.Message);
            }
        }
    }
}
