using BLL.Services.Main;
using BLL.Services;
using DAL.Models.Main;
using DTO;
using GUI.NewsFeed.Forms;
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
using DTO.Main;
using static GUI.NewsFeed.UserControls.Friends.UCFriendsForm;
using GUI.NewsFeed.UserControls.UCUserProfiles;

namespace GUI.NewsFeed.UserControls
{
    public partial class UCSearch : UserControl
    {
        List<int> _listUserIdResult;
        List<int> _listPostIdResult;

        PostingService postingService = new PostingService();
        LikeLoveService likeLoveService = new LikeLoveService();
        CommentsService commentsService = new CommentsService();
        AuthenticationService authenticationService = new AuthenticationService();
        FriendsService friendsService = new FriendsService();
        SelectedUserService SelectedUserService = new SelectedUserService();
        ShareService shareService;

        public List<PostingDto> postingList = new List<PostingDto>();
        public List<CommentsDto> commentsDtos = new List<CommentsDto>();
        public List<LikeLoveDto> likeLoveDtos = new List<LikeLoveDto>();
        public List<FriendRequestDto> friends = new List<FriendRequestDto>();
        public List<int> friendsId = new List<int>();
        public List<int> selectedUser = new List<int>();
        public List<ShareDto> listShare;
        public List<int> listSharePostId;
        public List<int> listFriendId;

        private int sessionId;
        private int userIdLogin;
        public UCSearch()
        {
            InitializeComponent();
            LoadAllResult();

            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);
            shareService = new ShareService();
        }
        public UCSearch(List<int> listUserIdResult, List<int> listPostIdResult)
        {
            InitializeComponent();

            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);
            shareService = new ShareService();

            _listUserIdResult = listUserIdResult;
            _listPostIdResult = listPostIdResult;
            LoadAllResult();
        }

        private void LoadAllResult()
        {
            LoadUserResult();
            LoadPostResult();
        }
        private void LoadUserResult()
        {
            flowLayoutPanel1.Controls.Clear();
            listFriendId = friendsService.GetFriendsIds(userIdLogin);
            foreach(var userId in _listUserIdResult)
            {
                if(userId == userIdLogin)
                {
                    continue;
                }
                UCFriendUI userSearch = new UCFriendUI();
                UserDto userDto = new UserDto();
                userDto = authenticationService.GetUserByUserId(userId);
                Image avatar = Image.FromFile(userDto.Avatar);
                string name = userDto.Name + " " + userDto.LastName;
                int isFriend = 0;
                if (listFriendId.Contains(userId))
                {
                    isFriend = 1;
                }

                userSearch.content(avatar, name, isFriend);
                userSearch.data(userIdLogin, userId, 1);
                userSearch.ButtonClicked += AllFriend_ButtonClicked;
                userSearch.ButtonClicked1 += AllFriend1_ButtonClicked;
                flowLayoutPanel1.Controls.Add(userSearch);

            }
        }
        private void AllFriend_ButtonClicked(object sender, EventArgs e)
        {
            UCFriendUI clickedUserControl = (UCFriendUI)sender;
        }
        public event EventHandler<UserClickedEventArgs> ssClicked;
        private void AllFriend1_ButtonClicked(object sender, EventArgs e)
        {
            UCFriendUI clickedUserControl = (UCFriendUI)sender;
            int id = clickedUserControl.GetCLickId();
            OnssClicked(id);
        }
        protected virtual void OnssClicked(int userId)
        {
            ssClicked?.Invoke(this, new UserClickedEventArgs(userId));
        }


        private void LoadPostResult()
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (var postIdd in _listPostIdResult)
            {
                PostingDto post = postingService.GetPostByPostId(postIdd);
                int id = post.UserPostId;
                int postOptionId = post.OptionId;
                selectedUser = SelectedUserService.GetSelectedUsers(post.PostId);
                switch (postOptionId)
                {
                    case 1:
                        // Xử lý trường hợp chia sẻ công khai
                        Hehe(post);
                        break;
                    case 2:
                        // Xử lý trường hợp chia sẻ bạn bè
                        if (friendsId.Contains(id) || id == userIdLogin)
                        {
                            Hehe(post);
                        }
                        break;
                    case 3:
                        // Xử lý trường hợp chia sẻ bạn bè ngoại trừ
                        if (!selectedUser.Contains(userIdLogin) && (friendsId.Contains(id) || id == userIdLogin))
                        {
                            Hehe(post);
                        }
                        break;
                    case 4:
                        // Xử lý trường hợp chia sẻ cụ thể
                        if (selectedUser.Contains(userIdLogin) && (friendsId.Contains(id) || id == userIdLogin))
                        {
                            Hehe(post);
                        }
                        break;
                    default:
                        if (id == userIdLogin)
                        {
                            Hehe(post);
                        }
                        // Xử lý trường hợp chia sẻ riêng tư
                        break;
                }
            }
        }
        private void Hehe(PostingDto post)
        {
            //Get user post
            UserDto userPost = authenticationService.GetUserByUserId(post.UserPostId);
            //Get comment in post
            commentsDtos = commentsService.GetCommentsByPostId(post.PostId, 0, 1000);
            int numComments = commentsDtos.Count;
            //Get like in post
            likeLoveDtos = likeLoveService.GetLikeLoveByPostId(post.PostId);
            int numLikeLoves = likeLoveDtos.Count;
            listSharePostId = shareService.GetSharesPosstId(post.PostId);
            int numShare = listSharePostId.Count();

            //Media
            List<MediaCustome> media = new List<MediaCustome>();
            string listFilePath = post.Media;

            string[] parts = listFilePath.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                MediaCustome mediaItem = new MediaCustome();
                if (part.StartsWith("video"))
                {
                    mediaItem.Type = "video";
                    mediaItem.Url = part.Substring("video".Length);
                }
                else if (part.StartsWith("image"))
                {
                    mediaItem.Type = "image";
                    mediaItem.Url = part.Substring("image".Length);
                }
                media.Add(mediaItem);
            }
            //end

            int postId = post.PostId;
            bool isUserLogginInList = false;
            foreach (var item in likeLoveDtos)
            {
                if (item.UserLikeId == userIdLogin)
                {
                    isUserLogginInList = true;
                    break;
                }
            }
            UCFeed feed = new UCFeed();

            feed.data(isUserLogginInList, post.Share, postId, userIdLogin, post.UserPostId, Image.FromFile(userPost.Avatar), userPost.Name, userPost.LastName, post.CreatedAt.ToString(), post.Caption, numLikeLoves.ToString(), numComments.ToString(), post.Share.ToString(), listFilePath);
            feed.content(post.OptionId, Image.FromFile(userPost.Avatar), userPost.Name, userPost.LastName, post.CreatedAt.ToString(), post.Caption, numLikeLoves.ToString(), numComments.ToString(), numShare.ToString(), media);
            feed.Profile1Clicked += Feed_Profile1Clicked;
            feed.Profile2Clicked += Feed_Profile2Clicked;
            feed.Choose1Clicked += Feed_Choose1Clicked;

            flowLayoutPanel2.Controls.Add(feed);
        }
        public event EventHandler<UserClickedEventArgs> ssProfile1Clicked;
        public event EventHandler<UserClickedEventArgs> ssProfile2Clicked;
        public event EventHandler ssChooes1Clicked;
        private void Feed_Choose1Clicked(object sender, EventArgs e)
        {
            UCFeed clickedUserControl = (UCFeed)sender;
            Onss3Clicked(sender, e);
        }

        private void Feed_Profile1Clicked(object sender, EventArgs e)
        {
            UCFeed clickedUserControl = (UCFeed)sender;
            int id = clickedUserControl.GetUserPostId();
            Onss1Clicked(id);
        }
        private void Feed_Profile2Clicked(object sender, EventArgs e)
        {
            UCFeed clickedUserControl = (UCFeed)sender;
            int id = clickedUserControl.GetUserPostId();
            Onss2Clicked(id);
        }
        protected virtual void Onss1Clicked(int userId)
        {
            ssProfile1Clicked?.Invoke(this, new UserClickedEventArgs(userId));
        }
        protected virtual void Onss2Clicked(int userId)
        {
            ssProfile2Clicked?.Invoke(this, new UserClickedEventArgs(userId));
        }
        protected virtual void Onss3Clicked(object sender, EventArgs e)
        {
            ssChooes1Clicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel2.Visible = true;
        }

        private void btnPosst_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel2.Visible = true;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel2.Visible = false;
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {

        }
    }
}
