using AxWMPLib;
using BLL.Services;
using BLL.Services.Main;
using DTO;
using GUI.NewsFeed.UserControls;
using GUI.NewsFeed.UserControls.Friends;
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

namespace GUI.NewsFeed.Forms
{
    public partial class PostingFrom : Form
    {
        private MainForm mainForm;
        private UCHome ucHome;


        PostingService postingService = new PostingService();
        FriendsService friendsService = new FriendsService();
        AuthenticationService authenticationService = new AuthenticationService();
        SelectedUserService selectedUserService = new SelectedUserService();
        private int sessionId;
        private int userIdLogin;
        string caption;
        int optionID = 1;
        string listFilePath;
        int _sharePostId = 0;

        List<int> friends = new List<int>();
        List<int> selectedFriends = new List<int>();

        public PostingFrom()
        {
            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);

            InitializeComponent();
            InitializeRadioButtons();
            mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            LoadFrendsIntoSelectTable();
            UserDto user__ = authenticationService.GetUserByUserId(userIdLogin);
            Image avatar = Image.FromFile(user__.Avatar);
            picAvatar.Image = avatar;
            lblName.Text = user__.Name + " " + user__.LastName;
        }
        public PostingFrom(int share, string media)
        {
            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);

            InitializeComponent();
            InitializeRadioButtons();
            mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            LoadFrendsIntoSelectTable();
            UserDto user__ = authenticationService.GetUserByUserId(userIdLogin);
            Image avatar = Image.FromFile(user__.Avatar);
            picAvatar.Image = avatar;
            lblName.Text = user__.Name + " " + user__.LastName;
            _sharePostId = share;
            listFilePath = media;

            pnlMedia.Visible = false;
            btnPost.Text = "Chia sẻ ngay";
        }
        private void btnAddImageFromFile_Click(object sender, EventArgs e)
        {
            // listpath tý clear.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media files (*.jpg, *.png, *.gif, *.mp4, *.wav)|*.jpg;*.png;*.gif;*.mp4;*.wav";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listFilePath = "";
                btnAddImageFromFile.Visible = false;
                flpImagePosting.Visible = true;
                foreach (string filePath in openFileDialog.FileNames)
                {
                    string fileExtension = System.IO.Path.GetExtension(filePath).ToLower();
                    if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".gif")
                    {
                        PictureBox newPicBox = new PictureBox();
                        newPicBox.Image = Image.FromFile(filePath);
                        newPicBox.SizeMode = PictureBoxSizeMode.Zoom;
                        newPicBox.Size = new Size(194, 194);
                        flpImagePosting.Controls.Add(newPicBox);
                        listFilePath += (";" + "image" + filePath);
                    }
                    else if (fileExtension == ".mp4" || fileExtension == ".wav")
                    {
                        AxWindowsMediaPlayer newVideoPlayer = new AxWindowsMediaPlayer();

                        newVideoPlayer.URL = filePath;
                        newVideoPlayer.uiMode = "none";
                        newVideoPlayer.stretchToFit = true;
                        newVideoPlayer.enableContextMenu = false;
                        newVideoPlayer.Size = new Size(194, 194);

                        flpImagePosting.Controls.Add(newVideoPlayer);

                        listFilePath += (";" + "video" + filePath);
                    }
                }
            }
        }

        private void picMedia_Click(object sender, EventArgs e)
        {
            pnlMedia.Visible = true;
            pnlStatitude.Visible = false;
        }

        private void picStatitude_Click(object sender, EventArgs e)
        {
            pnlMedia.Visible = false;
            pnlStatitude.Visible = true;
        }

        #region -> btnOptions
        #endregion
        private void btnOption_Click(object sender, EventArgs e)
        {
            flpOption.Visible = true;
        }
        private void InitializeRadioButtons()
        {
            radioButton1.CheckedChanged += RbOption_CheckedChanged;

            radioButton2.CheckedChanged += RbOption_CheckedChanged;

            radioButton3.CheckedChanged += RbOption_CheckedChanged;

            radioButton4.CheckedChanged += RbOption_CheckedChanged;

            radioButton5.CheckedChanged += RbOption_CheckedChanged;
        }
        private void RbOption_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                btnOption.Text = "     " + radioButton1.Text;
                flpOption.Visible = false;
                optionID = 1;
            }
            else if (radioButton2.Checked)
            {
                btnOption.Text = "     " + radioButton2.Text;
                flpOption.Visible = false;
                optionID = 2;
            }
            else if (radioButton3.Checked)
            {
                btnOption.Text = "     " + radioButton3.Text;
                flpOption.Visible = false;
                optionID = 3;
                pnlSelectForm.Visible = true;
            }
            else if (radioButton4.Checked)
            {
                btnOption.Text = "     " + radioButton4.Text;
                flpOption.Visible = false;
                optionID = 4;
                pnlSelectForm.Visible = true;
            }
            else if (radioButton5.Checked)
            {
                btnOption.Text = "     " + radioButton5.Text;
                flpOption.Visible = false;
                optionID = 5;
            }
        }
        private void GetFriends()
        {
            friends = friendsService.GetFriendsIds(userIdLogin);
        }
        private void LoadFrendsIntoSelectTable()
        {
            GetFriends();
            flpFriendsSelect.Controls.Clear();

            foreach (var friend in friends)
            {
                UserDto userFriend;
                
                userFriend = authenticationService.GetUserByUserId(friend);

                string name = userFriend.Name + " " + userFriend.LastName;
                Image friendAvatar = Image.FromFile(userFriend.Avatar);
                //end

                UCFriendSelect ucFriendSelect = new UCFriendSelect();
                ucFriendSelect.data(friend, 0);
                ucFriendSelect.content(friendAvatar, name, 0);
                ucFriendSelect.ButtonClicked += ButtonClicked;
                flpFriendsSelect.Controls.Add(ucFriendSelect);
            }
        }
        private void ButtonClicked(object sender, EventArgs e)
        {
            UCFriendSelect clickedUserControl = (UCFriendSelect)sender;
            int id = clickedUserControl.GetFriendId();

            if (selectedFriends.Contains(id))
            {
                selectedFriends.Remove(id);
            }
            else
            {
                selectedFriends.Add(id);
            }
        }


        private void ptbClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn huỷ bài viết", "Huỷ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            caption = txtCaption.Text;
            postingService.AddPost(userIdLogin, caption, optionID, listFilePath, -1, _sharePostId);

            mainForm.btnHome_Click(sender, e);


            int postId = postingService.GetMaxPostId();
            foreach (var user in selectedFriends)
            {
                selectedUserService.InsertSelectedUser(postId, user);
            }
            this.Hide();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            pnlSelectForm.Visible = false;
            selectedFriends.Clear();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            pnlSelectForm.Visible = false;
        }

        private void btnTakeAPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
