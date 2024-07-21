using BLL.Services;
using BLL.Services.Main;
using DAL.Models.Main;
using DTO;
using GUI.NewsFeed.Forms;
using GUI.NewsFeed.UserControls.Comments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NewsFeed.UserControls.UCUserProfiles
{
    public partial class UCPost_PF : UserControl
    {
        AuthenticationService authenticationService = new AuthenticationService();
        FriendsService friendsService = new FriendsService();
        PostingService postingService = new PostingService(); 
        LikeLoveService likeLoveService = new LikeLoveService();
        CommentsService commentsService = new CommentsService();

        private int sessionId;
        private int userIdLogin;

        UserDto user = new UserDto();
        List<int> friendIds = new List<int>();
        List<PostingDto> posting = new List<PostingDto>(); 
        public List<CommentsDto> commentsDtos = new List<CommentsDto>();
        public List<LikeLoveDto> likeLoveDtos = new List<LikeLoveDto>();
        public UCPost_PF()
        {
            InitializeComponent();

            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);

            LoadData();
        }
        public UCPost_PF(int userId)
        {
            InitializeComponent();

            sessionId = SessionManager.GetSessionId();
            //userIdLogin = SessionManager.GetuUserId(sessionId);
            userIdLogin = userId;

            LoadData();
        }
        private void GetUser()
        {
            user = authenticationService.GetUserByUserId(userIdLogin);
        }
        private void GetFriends()
        {
            friendIds = friendsService.GetFriendsIds(userIdLogin);
        }
        private void GetPosting()
        {
            posting = postingService.GetPost(userIdLogin);
        }
        private void LoadData()
        {
            GetUser();
            GetFriends();
            GetPosting();
            flpFeeds.Controls.Clear();
            flpFriends.Controls.Clear();
            flpPhotos.Controls.Clear();

            lblPhoneNumberReal.Text = user.PhoneNumber;
            lblEmailReal.Text = user.Email;

            foreach (var friend in friendIds)
            {
                UserDto user = authenticationService.GetUserByUserId(friend);
                Image avatar = Image.FromFile(user.Avatar);
                string name = user.Name + " " + user.LastName;
                UCFriends ucFriend = new UCFriends();
                ucFriend.content(avatar, name);
                flpFriends.Controls.Add(ucFriend);
            }
            foreach (var post in posting)
            {
                int postId = post.PostId;

                //Get comment in post
                commentsDtos = commentsService.GetCommentsByPostId(post.PostId, 0, 1000);
                int numComments = commentsDtos.Count;
                //Get like in post
                likeLoveDtos = likeLoveService.GetLikeLoveByPostId(post.PostId);
                int numLikeLoves = likeLoveDtos.Count;

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
                feed.data(isUserLogginInList, post.Share, postId, userIdLogin, post.UserPostId, Image.FromFile(user.Avatar), user.Name, user.LastName, post.CreatedAt.ToString(), post.Caption, numLikeLoves.ToString(), numComments.ToString(), post.Share.ToString(), listFilePath);
                feed.content(post.OptionId, Image.FromFile(user.Avatar), user.Name, user.LastName, post.CreatedAt.ToString(), post.Caption, numLikeLoves.ToString(), numComments.ToString(), post.Share.ToString(), media);

                flpFeeds.Controls.Add(feed);

                foreach (var photo in media)
                {
                    if(photo.Type == "image")
                    {
                        PictureBox pic = new PictureBox();
                        pic.Size = new Size(122, 122);
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Image = Image.FromFile(photo.Url);

                        flpPhotos.Controls.Add(pic);
                    }
                }
            }
        }
    }
}
