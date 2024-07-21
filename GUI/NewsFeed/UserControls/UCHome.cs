using BLL.Services;
using BLL.Services.Main;
using DAL.Models.Main;
using DTO;
using DTO.Main;
using GUI.NewsFeed.Forms;
using GUI.NewsFeed.UserControls.Comments;
using GUI.NewsFeed.UserControls.Friends;
using GUI.NewsFeed.UserControls.UCUserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.NewsFeed.UserControls.Friends.UCFriendsForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI.NewsFeed.UserControls
{
    public partial class UCHome : UserControl
    {
        public event EventHandler UserProfile_Clicked;
        public event EventHandler Video_Clicked;
        public event EventHandler Friends_Clicked;

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

        private int sessionId;
        private int userIdLogin;

        public UCHome()
        {
            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);
            shareService = new ShareService();

            InitializeComponent();
            LoadPostIntoTheFeed();
            LoadFriend();
            Design();

        }
        private void Design()
        {
            UserDto user = authenticationService.GetUserByUserId(userIdLogin);
            Image avatar = Image.FromFile(user.Avatar);
            string name = "            " + user.Name + " " + user.LastName;
            DesginButtonUserProfile(avatar);
            btnUserProfile.Text = name;
            picAvatar.Image = avatar;
        }

        #region -> Load Data
        private List<PostingDto> GetPostByUserId(int userId)
        {
            postingList = postingService.GetPost(userId, 0, 30);
            return postingList;
        }
        private List<PostingDto> GetAllPosts()
        {
            postingList = postingService.GetAllPosts(0, 30);
            return postingList;
        }
        private void GetFriend()
        {
            //Get friends
            friends = friendsService.GetFriendsList(userIdLogin);
            friendsId = friendsService.GetFriendsIds(userIdLogin);
        }
        public void LoadPostIntoTheFeed()
        {
            GetAllPosts();
            GetFriend();
            listShare = shareService.GetAllShares();
            flpDataContent.Controls.Clear();

            foreach (var post in postingList)
            {
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

            flpDataContent.Controls.Add(feed);
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

        private void LoadFriend()
        {
            GetFriend();
            flpFriends.Controls.Clear();
            flpGroups.Controls.Clear();

            foreach (var friend in friends)
            {
                UserDto userFriend;
                //Get friends
                if (friend.SenderId == userIdLogin)
                {
                    userFriend = authenticationService.GetUserByUserId(friend.ReceiverId);
                }
                else
                {
                    userFriend = authenticationService.GetUserByUserId(friend.SenderId);
                }    
                string friendName = userFriend.LastName + " " + userFriend.Name;
                Image friendAvatar = Image.FromFile(userFriend.Avatar);
                //end

                UCFriendsLong friendLong = new UCFriendsLong();
                friendLong.data(userFriend.UserId);
                friendLong.content(friendAvatar, friendName);
                friendLong.Button111Clicked += FriendLong_ButtonClicked;
                flpFriends.Controls.Add(friendLong);
            }
        }
        public event EventHandler<UserClickedEventArgs> ssLongFriend;
        private void FriendLong_ButtonClicked(object sender, EventArgs e)
        {
            UCFriendsLong clickedUserControl = (UCFriendsLong)sender;
            int id = clickedUserControl.GetUserFriendId();
            LongFriendClicked(id);
        }
        protected virtual void LongFriendClicked(int userId)
        {
            ssLongFriend?.Invoke(this, new UserClickedEventArgs(userId));
        }
        #endregion

        #region -> Design
        // Design btnUserProfile
        private Bitmap CreateRoundedImage(Image image, int size)
        {
            Bitmap bitmap = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, size, size);
                    using (var brush = new TextureBrush(image))
                    {
                        g.FillPath(brush, path);
                    }
                }
            }
            return bitmap;
        }
        void DesginButtonUserProfile(Image originalImage)
        {
            Image scaledImage = originalImage.GetThumbnailImage(32, 32, null, IntPtr.Zero);
            Image roundedImage = CreateRoundedImage(scaledImage, 32);
            btnUserProfile.Image = roundedImage;
            btnUserProfile.ImageAlign = ContentAlignment.MiddleLeft;
        }
        // end


        #endregion

        #region -> Mouse

        #endregion

        #region ->Navigate
        private void lblAsk_Click(object sender, EventArgs e)
        {

        }

        private void disignAsk_Click(object sender, EventArgs e)
        {

        }

        private void btnPostMdeia_Click(object sender, EventArgs e)
        {
            NavigateToPostingFrom();
        }

        private void btnPostStatitude_Click(object sender, EventArgs e)
        {
            NavigateToPostingFrom();
        }

        private void NavigateToPostingFrom()
        {
            PostingFrom posting = new PostingFrom();
            posting.ShowDialog();
        }
        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            UserProfile_Clicked?.Invoke(sender, e);
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Video_Clicked?.Invoke(sender, e);
        }
        #endregion

        private void btnFriends_Click(object sender, EventArgs e)
        {
            Friends_Clicked?.Invoke(sender, e);
        }
    }
}
