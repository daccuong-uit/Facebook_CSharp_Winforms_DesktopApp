using System;
using BLL.Services;
using GUI.AppSettings;
using GUI.Messaging.Forms;
using GUI.NewsFeed.UserControls;
using GUI.UserManagement.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Controls.ChatControls;
using GUI.Controls;
using GUI.NewsFeed.UserControls.UCUserProfiles;
using BLL.Services.Main;
using GUI.NewsFeed.UserControls.Friends;
using GUI.NewsFeed.UserControls.Comments;
using DTO.Main;
using DTO;
using static GUI.NewsFeed.UserControls.Friends.UCFriendsForm;
using static System.Net.Mime.MediaTypeNames;
using DAL.Models.Main;

namespace GUI.NewsFeed.Forms
{
    public partial class MainForm : BaseForm
    {
        public Panel pnlContented { get; private set; }
        protected UCHome ucHome;

        protected UCVideo ucVideo;
        protected UCGroup ucGroup;
        protected UCUserProfile ucUserProfile;
        protected UCFeed ucFeed;
        private UCFriendsForm ucFriendsForm;
        protected UCSuggestFriend ucSuggestFriend;
        protected UCFriendAccept ucFriendAccept;
        protected UCSearch ucSearch;

        AuthenticationService authenticationService;
        FriendsService friendsService = new FriendsService();
        protected PostingService postingService = new PostingService();

        private int sessionId;
        private int userIdLogin;


        public List<FriendRequestDto> friends = new List<FriendRequestDto>();

        private List<int> listAllPostId = new List<int>();
        private List<int> listUserPostId = new List<int>();
        List<PostingDto> listAllPost = new List<PostingDto>();
        private UserDto userLoggedIn;

        private DataTable dtPostStatus;
        private DataTable dtUerFullName;

        List<int> listUserIdResult = new List<int>();
        List<int> listPostIdResult = new List<int>();

        public MainForm()
        {
            InitializeComponent();
            pnlContented = pnlContent;

            authenticationService = new AuthenticationService();
            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);

            DesignMain();

            //DarkMode
            DarkMode.OnDarkModeChanged += DarkMode_OnDarkModeChanged;
            UpdateUIBasedOnDarkMode(DarkMode.IsDarkModeEnabled);

            //English
            Language.OnEnglishChanged += English_OnEnglishChanged;
            UpdateUIBasedOnEnglish(Language.IsEnglishEnabled);

            //UC
            ucHome = new UCHome();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(ucHome);
            ucHome.Visible = true;
            ucHome.UserProfile_Clicked += UCHome_UserProfile_Clicked;
            ucHome.Video_Clicked += UCHome_Video_Clicked;
            ucHome.Friends_Clicked += UChome_Friends_Clicked;
            ucHome.ssProfile1Clicked += UcFriendsForm_ssClicked;
            ucHome.ssProfile2Clicked += UcFriendsForm_ssClicked;
            ucHome.ssLongFriend += UcFriendsForm_ssClicked;
            ucHome.ssChooes1Clicked += HiHi;

            ucSuggestFriend = new UCSuggestFriend();
            ucFriendsForm = new UCFriendsForm();
        }

        #region -> Friends
        #endregion

        public void SetOption(int optionId)
        {
            ucFeed = new UCFeed();
            ucFeed.SetOption(optionId);
        }
        private void HiHi(object sender, EventArgs e)
        {

        }
        public void SeeLikeCmtPeople(UCUserProfile ucUserProfile)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(ucUserProfile);
        }
        private void GetData()
        {
            //Get friends
            friends = friendsService.GetFriendsList(userIdLogin);
            userLoggedIn = authenticationService.GetUserByUserId(userIdLogin);
        }

        #region -> DesignSearchOnFace
        private void DesignSearchOnFace()
        {
            picSearch.Visible = false;
            txtSearchOnFace.Visible = true;
            txtSearchOnFace.Focus();
        }
        private void DesignMain()
        {
            GetData();
            System.Drawing.Image avatar = System.Drawing.Image.FromFile(userLoggedIn.Avatar);
            string name = userLoggedIn.Name + " " + userLoggedIn.LastName;

            picAvatar.Image = avatar;
            btnMyUser.Text = name;
            picAvatarBar.Image = avatar;
        }

        private void Reset()
        {
            if (string.IsNullOrEmpty(txtSearchOnFace.Text))
            {
                lblSearch.Visible = true;
            }
            else
            {
                lblSearch.Visible = false;
            }
            picSearch.Visible = true;
        }

        private void picSearch_MouseClick(object sender, MouseEventArgs e)
        {
            DesignSearchOnFace();
        }

        private void customeInpputTextBox1_Click(object sender, EventArgs e)
        {
            DesignSearchOnFace();
        }
        private void customeInpputTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DesignSearchOnFace();
        }
        private void lblSearch_Click(object sender, EventArgs e)
        {
            DesignSearchOnFace();
        }

        private void txtSearchOnFace_TextChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtSearchOnFace_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchOnFace.Text))
            {
                lblSearch.Visible = false;
            }
        }

        private void txtSearchOnFace_Leave(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion

        #region -> UserSettingDialog
        // Open messenger mini
        private void customButton2_Click(object sender, EventArgs e)
        {
            if (pnlGoToMess.Visible == false)
            {
                pnlGoToMess.Visible = true;
                pnlMessengerMini.Visible = true;
            }
            else
            {
                pnlGoToMess.Visible = false;
                pnlMessengerMini.Visible = false;
            }
        }

        //Go to Chat Form
        private void pnlGoToMess_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.Show();
            this.Hide();
        }
        private void lblGoToMessenger_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.Show();
            this.Hide();
        }

        // Open setting and user dialog
        private void customePicture1_Click(object sender, EventArgs e)
        {
            if (pnlUser.Visible == false)
            {
                pnlUser.Visible = true;
            }
            else
            {
                pnlUser.Visible = false;
            }
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Logout(userIdLogin);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.White;
        }
        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Red;
        }
        #endregion

        #region -> Navigate
        //private void MyUserComtrolsContent_Load(object sender, EventArgs e)
        //{
        //    ucHome = new UCHome();
        //    if (!pnlContent.Controls.Contains(ucHome))
        //    {
        //        ucHome.UserProfile_Clicked += UCHome_UserProfile_Clicked;
        //        ucHome.Video_Clicked += UCHome_Video_Clicked;
        //        ucHome.Friends_Clicked += UChome_Friends_Clicked;
        //        ucHome.ssProfile1Clicked += UcFriendsForm_ssClicked;
        //        ucHome.ssProfile2Clicked += UcFriendsForm_ssClicked;
        //        ucHome.ssLongFriend += UcFriendsForm_ssClicked;
        //        ucHome.ssChooes1Clicked += HiHi;
        //        pnlContent.Controls.Add(ucHome);
        //    }

        //    ucHome.Visible = true;
        //}

        public void btnHome_Click(object sender, EventArgs e)
        {
            ucHome = new UCHome();
            pnlContent.Controls.Clear();
            ucHome.UserProfile_Clicked += UCHome_UserProfile_Clicked;
            ucHome.Video_Clicked += UCHome_Video_Clicked;
            ucHome.Friends_Clicked += UChome_Friends_Clicked;
            ucHome.ssProfile1Clicked += UcFriendsForm_ssClicked;
            ucHome.ssProfile2Clicked += UcFriendsForm_ssClicked;
            ucHome.ssLongFriend += UcFriendsForm_ssClicked;
            ucHome.ssChooes1Clicked += HiHi;
            pnlContent.Controls.Add(ucHome);
            ucHome.LoadPostIntoTheFeed();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucVideo = new UCVideo();
            pnlContent.Controls.Add(ucVideo);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucGroup = new UCGroup();
            pnlContent.Controls.Add(ucGroup);
        }
        protected virtual void UCHome_UserProfile_Clicked(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucUserProfile = new UCUserProfile();
            ucUserProfile.DesignUerProfile();
            pnlContent.Controls.Add(ucUserProfile);
        }
        protected virtual void UChome_Friends_Clicked(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucFriendsForm = new UCFriendsForm();
            ucFriendsForm.ssClicked += UcFriendsForm_ssClicked;
            pnlContent.Controls.Add(ucFriendsForm);
        }

        private void UcFriendsForm_ssClicked(object sender, UserClickedEventArgs e)
        {
            int userId = e.UserId;
            pnlContent.Controls.Clear();
            ucUserProfile = new UCUserProfile(userId);
            ucUserProfile.DesignFriendProfile(true);
            pnlContent.Controls.Add(ucUserProfile);
        }

        protected virtual void UCHome_Video_Clicked(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ucVideo = new UCVideo();
            pnlContent.Controls.Add(ucVideo);
        }
        #endregion

        #region -> Dark mode
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (DarkMode.IsDarkModeEnabled == false)
            {
                DarkMode.IsDarkModeEnabled = true;
            }
            else
            {
                DarkMode.IsDarkModeEnabled = false;
            }
        }
        private void DarkMode_OnDarkModeChanged(bool isDarkModeEnabled)
        {
            UpdateUIBasedOnDarkMode(isDarkModeEnabled);
        }
        private void UpdateUIBasedOnDarkMode(bool isDarkModeEnabled)
        {
            if (isDarkModeEnabled)
            {
                this.BackColor = ColorTranslator.FromHtml("#18191a");
                windowControls.BackColor = ColorTranslator.FromHtml("#1877f2");
                // ControlTab
                pnlControlTab.BackColor = ColorTranslator.FromHtml("#18191a");
                btnAnouncement.BackColor = ColorTranslator.FromHtml("#1877f2");
                btnMessenger.BackColor = ColorTranslator.FromHtml("#1877f2");

                //
                // MessengerMini
                pnlMessengerMini.BackColor = ColorTranslator.FromHtml("#3a3b3c");

                lblTextChat.ForeColor = ColorTranslator.FromHtml("#ffffff");
                txtSearchInMess.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                txtSearchInMess.BorderColor = ColorTranslator.FromHtml("#3a3b3c");

                btnMessageBox.BackColor = ColorTranslator.FromHtml("#1877f2");
                btnMessageBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnComunication.BackColor = ColorTranslator.FromHtml("#1877f2");
                btnComunication.ForeColor = ColorTranslator.FromHtml("#ffffff");

                // User
                pnlUser.BackColor = ColorTranslator.FromHtml("#18191a");

                pnlProfile.BackColor = ColorTranslator.FromHtml("#18191a");
                pnlProfile.BorderColor = ColorTranslator.FromHtml("#3a3b3c");
                btnMyUser.BackColor = ColorTranslator.FromHtml("#18191a");
                btnMyUser.BorderColor = ColorTranslator.FromHtml("#18191a");
                btnMyUser.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnGotoMyUser.BackColor = ColorTranslator.FromHtml("#18191a");
                btnGotoMyUser.BorderColor = ColorTranslator.FromHtml("#18191a");
                customButton5.BorderColor = ColorTranslator.FromHtml("#3a3b3c");

                btnDarkMode.BackColor = ColorTranslator.FromHtml("#18191a");
                btnChangeLan.BackColor = ColorTranslator.FromHtml("#18191a");
                btnLogout.BackColor = ColorTranslator.FromHtml("#18191a");
                btnDarkMode.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnChangeLan.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnLogout.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnDarkMode.Image = Properties.Resources._32_white_moon;
                btnLogout.Image = Properties.Resources._32_white_logout;
                btnDarkMode.Text = "          Tắt chế độ ban đêm";
            }
            else
            {
                this.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                windowControls.BackColor = ColorTranslator.FromHtml("#ffffff");
                // ControlTab
                pnlControlTab.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnAnouncement.BackColor = ColorTranslator.FromHtml("#ffffff");

                // MessengerMini
                pnlMessengerMini.BackColor = ColorTranslator.FromHtml("#f6f7f8");

                lblTextChat.ForeColor = ColorTranslator.FromHtml("#000000");
                txtSearchInMess.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                txtSearchInMess.BorderColor = ColorTranslator.FromHtml("#f6f7f8");

                btnMessageBox.BackColor = ColorTranslator.FromHtml("#f0f8ff");
                btnMessageBox.ForeColor = ColorTranslator.FromHtml("#1877f2");
                btnComunication.BackColor = ColorTranslator.FromHtml("#f0f8ff");
                btnComunication.ForeColor = ColorTranslator.FromHtml("#1877f2");

                // User
                pnlUser.BackColor = ColorTranslator.FromHtml("#ffffff");

                pnlProfile.BackColor = ColorTranslator.FromHtml("#ffffff");
                pnlProfile.BorderColor = ColorTranslator.FromHtml("#dcdcdc");
                btnMyUser.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnMyUser.BorderColor = ColorTranslator.FromHtml("#ffffff");
                btnMyUser.ForeColor = ColorTranslator.FromHtml("#000000");
                btnGotoMyUser.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnGotoMyUser.BorderColor = ColorTranslator.FromHtml("#ffffff");
                customButton5.BorderColor = ColorTranslator.FromHtml("#dcdcdc");

                btnDarkMode.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnChangeLan.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnLogout.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnDarkMode.ForeColor = ColorTranslator.FromHtml("#000000");
                btnChangeLan.ForeColor = ColorTranslator.FromHtml("#000000");
                btnLogout.ForeColor = ColorTranslator.FromHtml("#000000");
                btnDarkMode.Image = Properties.Resources._32_black_empty_moon;
                btnLogout.Image = Properties.Resources._32_black_logout;
                btnDarkMode.Text = "          Bật chế độ ban đêm";
            }
        }
        #endregion

        #region -> Language

        private void btnChangeLan_Click(object sender, EventArgs e)
        {
            if (Language.IsEnglishEnabled == false)
            {
                Language.IsEnglishEnabled = true;
            }
            else
            {
                Language.IsEnglishEnabled = false;
            }
        }
        private void English_OnEnglishChanged(bool isEnglishEnabled)
        {
            UpdateUIBasedOnEnglish(isEnglishEnabled);
        }
        private void UpdateUIBasedOnEnglish(bool isEnglishEnabled)
        {
            if (isEnglishEnabled == true)
            {
                lblTextChat.Text = "Chats    ";
                txtSearchInMess.PlaceholderText = "Search Friends";
                txtSearchInMess.Texts = "";
                btnMessageBox.Text = "Inbox";
                btnComunication.Text = "Communities";
                lblGoToMessenger.Text = "Try Messengers for Windows";

                btnGotoMyUser.Text = "See all profiles";
                btnDarkMode.Text = "          Turn on Darkmode";
                btnChangeLan.Text = "          Change language";
                btnChangeLan.Image = Properties.Resources._32_black_english;
                btnLogout.Text = "          Logout";
            }
            else
            {
                lblTextChat.Text = "Đoạn Chat";
                txtSearchInMess.PlaceholderText = "Tìm kiếm bạn bè";
                txtSearchInMess.Texts = "";
                btnMessageBox.Text = "Hộp thư";
                btnComunication.Text = "Cộng đồng";
                lblGoToMessenger.Text = "Dùng Messenger cho Windows";

                btnGotoMyUser.Text = "Xem trang cá nhân";
                btnDarkMode.Text = "          Bật chế độ ban đêm";
                btnChangeLan.Text = "          Chuyển đổi ngôn ngữ Anh/Việt";
                btnChangeLan.Image = Properties.Resources._32_black_vietnam;
                btnLogout.Text = "          Đăng xuất";

            }
        }
        #endregion

        private void picSearch_Click(object sender, EventArgs e)
        {
            PerformSearch(txtSearchOnFace.Text);
        }

        private void txtSearchOnFace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch(txtSearchOnFace.Text);
            }
        }
        private void GetId()
        {
            listAllPost = postingService.GetAllPosts(0,1000);
            listUserPostId = authenticationService.GetAllUserIds();

            dtPostStatus = new DataTable();
            dtPostStatus.Columns.Add("PostId", typeof(int));
            dtPostStatus.Columns.Add("Caption", typeof(string));

            dtUerFullName = new DataTable();
            dtUerFullName.Columns.Add("UserId", typeof(int));
            dtUerFullName.Columns.Add("FullName", typeof(string));

            foreach (var post in listAllPost)
            {
                int postId = post.PostId;
                string caption = post.Caption;
                dtPostStatus.Rows.Add(postId, caption);
            }

            foreach (var userId in listUserPostId)
            {
                UserDto user = authenticationService.GetUserByUserId(userId);
                int userIdd = user.UserId;
                string fullname = user.Name + " " + user.LastName;
                dtUerFullName.Rows.Add(userIdd, fullname);
            }
        }
        private void PerformSearch(string searchText)
        {
            GetId();
            listUserIdResult.Clear();
            listPostIdResult.Clear();
            foreach (DataRow row in dtUerFullName.Rows)
            {
                int userId = (int)row["UserId"];
                string fullName = row["FullName"].ToString();
                if (fullName.ToLower().Contains(searchText.ToLower()))
                {
                    listUserIdResult.Add(userId);
                }
            }
            foreach (DataRow row in dtPostStatus.Rows)
            {
                int postId = (int)row["PostId"];
                string caption = row["Caption"].ToString();
                if (caption.ToLower().Contains(searchText.ToLower()))
                {
                    listPostIdResult.Add(postId);
                }
            }

            pnlContent.Controls.Clear();
            ucSearch = new UCSearch(listUserIdResult, listPostIdResult);
            ucSearch.ssProfile1Clicked += UcFriendsForm_ssClicked;
            ucSearch.ssProfile2Clicked += UcFriendsForm_ssClicked;
            ucSearch.ssChooes1Clicked += HiHi;
            ucSearch.ssClicked += UcFriendsForm_ssClicked;
            pnlContent.Controls.Add(ucSearch);
        }
    }
}
