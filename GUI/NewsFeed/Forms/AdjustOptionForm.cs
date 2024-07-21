using BLL.Services;
using BLL.Services.Main;
using DTO;
using GUI.NewsFeed.UserControls.Friends;
using GUI.NewsFeed.UserControls.UCUserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NewsFeed.Forms
{
    public partial class AdjustOptionForm : Form
    {
        private int _optionID;
        private int temp;
        private int _postId;
        private int _userLoggedIn;
        FriendsService friendsService;
        AuthenticationService authenticationService;
        SelectedUserService selectedUserService;
        MainForm mainForm;
        PostingService postingService;

        List<int> friendList = new List<int>();
        List<int> selectedFriends = new List<int>();
        public AdjustOptionForm()
        {
            InitializeComponent();
            friendsService = new FriendsService();
            authenticationService  = new AuthenticationService();
            selectedUserService = new SelectedUserService();
            mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            postingService = new PostingService();
            LoadFrendsIntoSelectTable();
        }
        public AdjustOptionForm(int userLoggedin, int optionId, int postId)
        {
            InitializeComponent();
            friendsService = new FriendsService();
            authenticationService = new AuthenticationService();
            selectedUserService = new SelectedUserService();
            mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            postingService = new PostingService();

            _userLoggedIn = userLoggedin;
            _optionID = optionId;
            temp = optionId; 
            _postId = postId;
            LoadFrendsIntoSelectTable();
        }
        private void GetFriend()
        {
            friendList = friendsService.GetFriendsIds(_userLoggedIn);
        }
        private void LoadFrendsIntoSelectTable()
        {
            GetFriend();
            flpFriendsSelect.Controls.Clear();

            foreach (var friend in friendList)
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
        private void btnTakeAPhoto_Click(object sender, EventArgs e)
        {
            _optionID = 1;
            mainForm.SetOption(_optionID);
            UpdateOption();
            this.Hide();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            _optionID = 2;
            mainForm.SetOption(_optionID);
            UpdateOption();
            this.Hide();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            _optionID = 3;
            mainForm.SetOption(_optionID);
            UpdateOption();
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            _optionID = 4;
            mainForm.SetOption(_optionID);
            UpdateOption();
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            _optionID = 5;
            mainForm.SetOption(_optionID);
            UpdateOption();
            this.Hide();

        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Huỷ chỉnh sửa", "Huỷ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            selectedFriends.Clear();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void customButton6_Click(object sender, EventArgs e)
        {
            _optionID = temp;
            this.Hide();
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            foreach (var user in selectedFriends)
            {
                selectedUserService.InsertSelectedUser(_postId, user);
            }
            mainForm.SetOption(_optionID);
            this.Hide();
        }
        private void UpdateOption()
        {
            postingService.UpdateOption(_postId, _optionID);
        }
    }
}
