using BLL.Services;
using BLL.Services.Main;
using DAL.Models.Main;
using DTO;
using DTO.Main;
using GUI.Controls;
using GUI.NewsFeed.Forms;
using GUI.NewsFeed.UserControls.Comments;
using GUI.UserManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NewsFeed.UserControls
{
    public partial class UCFeed : UserControl
    {
        public event EventHandler CommentButton_Clicked;

        List<MediaCustome> mediaInFeed;
        List<CommentsDto> listComment;
        private int _postId;
        private int _userIdLogin;
        private int _userPostId;
        private Image _avatar;
        private string _name;
        private string _lastname;
        private string _createdAt;
        private string _caption;
        private string _numLikeLoves;
        private string _numComments;
        private string _numShares;
        private string _media;
        private int _isShare;
        private bool _isUserLogginInList;
        private int _optionId;

        LikeLoveService likeLoveService;
        CommentsService commentsService;
        AuthenticationService authenticationService;
        PostingService postingService;
        ShareService shareService;
        public UCFeed()
        {
            InitializeComponent();
            likeLoveService = new LikeLoveService();
            commentsService = new CommentsService();
            authenticationService = new AuthenticationService();
            postingService = new PostingService();
            shareService = new ShareService();

        }
        public void data(bool isUserLogginInList, int isShare, int postId, int userId, int userPostId, Image avatar, string name, string lastname, string createdAt, string caption, string numLikeLoves, string numComments, string numShares, string media)
        {
            _isUserLogginInList = isUserLogginInList;
            _userPostId = userPostId;
            _postId = postId;
            _userIdLogin = userId;
            _avatar = avatar;
            _name = name;
            _lastname = lastname;
            _createdAt = createdAt;
            _caption = caption;
            _numLikeLoves = numLikeLoves;
            _numComments = numComments;
            _numShares = numShares;
            _media = media;
            _isShare = isShare;
        }
        public void content(int optionId, Image avatar, string name, string lastName, string CreatedAt, string caption, string like, string cmt, string share, List<MediaCustome> media)
        {
            _optionId = optionId;
            if (_userIdLogin == _userPostId)
            {
                button2.Text = "Chỉnh sửa đối tượng";
            }
            if (_isShare > 0)
            {
                flowLayoutPanel1.Visible = true;

                PostingDto postin = postingService.GetPostByPostId(_isShare);
                UserDto shareUser = authenticationService.GetUserByUserId(postin.UserPostId);

                Image shareAvatar = Image.FromFile(shareUser.Avatar);
                string nameBiShare = shareUser.Name + " " + shareUser.LastName;
                string postAt = postin.CreatedAt.ToString();
                string captionBiShare = postin.Caption;

                customePicture1.Image = shareAvatar;
                label3.Text = postAt;
                label4.Text = nameBiShare;
                label2.Text = captionBiShare;
            }
            else
            {
                flowLayoutPanel1.Visible = false;
            }
            if (_isUserLogginInList)
            {
                bttnLike.Image = Properties.Resources._24_blue_like;
                bttnLike.Width = 197;
            }
            mediaInFeed = media;
            picAvatar.Image = avatar;
            lblName.Text = name + " " + lastName;
            lblCreatedAt.Text = CreatedAt;
            lblCaption.Text = caption;
            lblLike.Text = like;
            lblCmt.Text = cmt + " Bình luận";
            lblShare.Text = share + " Chia sẻ";
            picEmo2.Image = Properties.Resources._24_blue_like;

            switch (optionId)
            {
                case 1:
                    lblOption.Text = "Công khai";
                    break;
                case 2:
                    lblOption.Text = "Bạn bè";
                    break;
                case 3:
                    lblOption.Text = "Bạn bè ngoại trừ";
                    break;
                case 4:
                    lblOption.Text = "Bạn bè cụ thể";
                    break;
                case 5:
                    lblOption.Text = "Chỉ mình tôi";
                    break;
                default:
                    lblOption.Text = "";
                    break;
            }

            //Add media
            int count = media.Count;
            flpMediaPost.Controls.Clear();
            if(count < 3)
            {
                foreach (var item in media)
                {
                    if (item.Type == "image")
                    {
                        Image image = Image.FromFile(item.Url);
                        int imageWidth = image.Width;
                        int imageHeight = image.Height;
                        float aspectRatio = (float)imageWidth / imageHeight;
                        int newWidth, newHeight;
                        if (aspectRatio > 1)
                        {
                            newWidth = 600;
                            newHeight = (int)(600 / aspectRatio);
                        }
                        else
                        {
                            newHeight = 600;
                            newWidth = (int)(600 * aspectRatio);
                        }

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(newWidth, newHeight);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.LoadAsync(item.Url);
                        flpMediaPost.Controls.Add(pictureBox);
                    }
                    else if (item.Type == "video")
                    {
                        // Thêm code để hiển thị video vào flpMediaPost
                        // Ví dụ:
                        // AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
                        // axWindowsMediaPlayer.URL = item.Url;
                        // flpMediaPost.Controls.Add(axWindowsMediaPlayer);
                    }
                }
            }
            if (count == 3)
            {
                int firstImageWidth = 0;
                int firstImageHeight = 0;
                int countI = 1;
                foreach (var item in media)
                {
                    if (item.Type == "image")
                    {
                        Image image = Image.FromFile(item.Url);
                        int imageWidth = image.Width;
                        int imageHeight = image.Height;
                        float aspectRatio = (float)imageWidth / imageHeight;
                        int newWidth, newHeight;

                        if (countI == 1)
                        {
                            if (aspectRatio > 1)
                            {
                                newWidth = 600;
                                newHeight = (int)(600 / aspectRatio);
                            }
                            else
                            {
                                newHeight = 600;
                                newWidth = (int)(600 * aspectRatio);
                            }

                            firstImageWidth = newWidth;
                            firstImageHeight = newHeight;
                        }
                        else
                        {
                            if (aspectRatio > 1)
                            {
                                newWidth = firstImageWidth / 2 - 5;
                                newHeight = (int)(newWidth / aspectRatio);
                            }
                            else
                            {
                                newWidth = firstImageWidth / 2 - 5;
                                newHeight = (int)(newWidth * aspectRatio);
                            }
                        }

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(newWidth, newHeight);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.LoadAsync(item.Url);
                        flpMediaPost.Controls.Add(pictureBox);
                    }
                    else if (item.Type == "video")
                    {
                        // Thêm code để hiển thị video vào flpMediaPost
                        // Ví dụ:
                        // AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
                        // axWindowsMediaPlayer.URL = item.Url;
                        // flpMediaPost.Controls.Add(axWindowsMediaPlayer);
                    }

                    countI++;
                }
            }
            if (count == 4 || count > 4)
            {
                btnSeeMore.Visible = true;
                int firstImageWidth = 0;
                int firstImageHeight = 0;
                int countI = 1;
                foreach (var item in media)
                {
                    if (item.Type == "image")
                    {
                        Image image = Image.FromFile(item.Url);
                        int imageWidth = image.Width;
                        int imageHeight = image.Height;
                        float aspectRatio = (float)imageWidth / imageHeight;
                        int newWidth, newHeight;
                        if(countI == 4)
                        {
                            break;
                        }

                        if (countI == 1)
                        {
                            if (aspectRatio > 1)
                            {
                                newWidth = 600;
                                newHeight = (int)(600 / aspectRatio);
                            }
                            else
                            {
                                newHeight = 600;
                                newWidth = (int)(600 * aspectRatio);
                            }

                            firstImageWidth = newWidth;
                            firstImageHeight = newHeight;
                        }
                        else
                        {
                            if (aspectRatio > 1)
                            {
                                newWidth = firstImageWidth / 2 - 5;
                                newHeight = (int)(newWidth / aspectRatio);
                            }
                            else
                            {
                                newWidth = firstImageWidth / 2 - 5;
                                newHeight = (int)(newWidth * aspectRatio);
                            }
                        }

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(newWidth, newHeight);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.LoadAsync(item.Url);
                        flpMediaPost.Controls.Add(pictureBox);
                    }
                    else if (item.Type == "video")
                    {
                        // Thêm code để hiển thị video vào flpMediaPost
                        // Ví dụ:
                        // AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
                        // axWindowsMediaPlayer.URL = item.Url;
                        // flpMediaPost.Controls.Add(axWindowsMediaPlayer);
                    }

                    countI++;
                }
            }
            

        }
        public int GetUserPostId()
        {
            return _userPostId;
        }
        private void btnSeeMore_Click(object sender, EventArgs e)
        {
            if(flpMediaPostDiaLog.Visible == false)
            {
                flpMediaPost.Visible = false;
                flpMediaPostDiaLog.Visible = true;
                btnSeeMore.Text = "Thu gọn";
                flpMediaPostDiaLog.Controls.Clear();
                foreach (var item in mediaInFeed)
                {
                    if (item.Type == "image")
                    {
                        Image image = Image.FromFile(item.Url);
                        int imageWidth = image.Width;
                        int imageHeight = image.Height;
                        float aspectRatio = (float)imageWidth / imageHeight;
                        int newWidth, newHeight;
                        if (aspectRatio > 1)
                        {
                            newWidth = 600;
                            newHeight = (int)(600 / aspectRatio);
                        }
                        else
                        {
                            newHeight = 600;
                            newWidth = (int)(600 * aspectRatio);
                        }

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(newWidth, newHeight);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.LoadAsync(item.Url);
                        flpMediaPostDiaLog.Controls.Add(pictureBox);
                    }
                    else if (item.Type == "video")
                    {
                        // Thêm code để hiển thị video vào flpMediaPost
                        // Ví dụ:
                        // AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
                        // axWindowsMediaPlayer.URL = item.Url;
                        // flpMediaPost.Controls.Add(axWindowsMediaPlayer);
                    }
                }
            }
            else
            {
                flpMediaPost.Visible = true;
                flpMediaPostDiaLog.Visible = false;
                btnSeeMore.Text = "Xem thêm";
            }
        }

        private void btnCmt_Click(object sender, EventArgs e)
        {

            listComment = commentsService.GetCommentsByPostId(_postId, 0, 1000);
            CommentButton_Clicked?.Invoke(sender, e);
            if(flpCmtTable.Visible == true)
            {
                flpCmtTable.Visible = false;
                pnlCommentInput.Visible = false;
            }
            else
            {
                flpCmtTable.Visible = true;
                pnlCommentInput.Visible = true;
            }
            LoadComment();
        }

        private void txtInputCmt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputCmt.Text))
            {
                label1.Visible = true;
                picSend.Visible = false;
                customeInpputTextBox1.Size = new Size(554, 40);
            }
            else
            {
                label1.Visible = false;
                picSend.Visible = true;
                customeInpputTextBox1.Size = new Size(520, 40);
            }
        }

        public class LikeButtonClickedEventArgs : EventArgs
        {
            public bool IsLiked { get; set; }
        }

        private void bttnLike_Click(object sender, EventArgs e)
        {
            int like;
            int likeId = likeLoveService.GetLikeIdByUserLikeIdAndPostId(_userIdLogin, _postId);
            if (bttnLike.Width == 197)
            {
                bttnLike.Image = Properties.Resources._32_dimgray_like;
                bttnLike.Width = 198;
                bttnLike.TextAlign = ContentAlignment.MiddleCenter;
                likeLoveService.GetLikeLoveByPostId(_postId);
                likeLoveService.DeleteLikeLove(likeId); 
                like = int.Parse(_numLikeLoves);
                lblLike.Text = like.ToString();
            }
            else
            {
                bttnLike.Image = Properties.Resources._24_blue_like;
                bttnLike.Width = 197;
                if (likeId == 0)
                {
                    likeLoveService.CreateLikeLove(_postId, _userIdLogin, 1);
                }
                else
                {
                    likeLoveService.CreateLikeLove(_postId, _userIdLogin, 1);
                }
                like = int.Parse(_numLikeLoves);
                like++;
                lblLike.Text = like.ToString();
            }
        }
        private void LoadComment()
        {
            flpCmtTable.Controls.Clear();
            foreach (var comment in listComment)
            {
                string cmt = comment.Content;
                int userCmt = comment.UserCommentId;
                UserDto userDto = new UserDto();
                userDto = authenticationService.GetUserByUserId(userCmt);
                string avatarr = userDto.Avatar;
                string userNamee = userDto.LastName + " " + userDto.Name;
                UCComments ucComments = new UCComments();
                ucComments.content(Image.FromFile(avatarr), userNamee, cmt);
                flpCmtTable.Controls.Add(ucComments);
            }
        }

        private void picSend_Click(object sender, EventArgs e)
        {
            int cmtCount;
            cmtCount = int.Parse(_numComments);
            cmtCount++;
            lblCmt.Text = cmtCount.ToString() + " Bình luận";
            string cmt = txtInputCmt.Text;
            int commentId = commentsService.GetMaxCommentId();
            CommentsDto newComment = new CommentsDto
            {
                CommentId = commentId + 1,
                PostId = _postId,
                UserCommentId = _userIdLogin,
                Content = cmt,
                CreatedAt = DateTime.Now,
            };
            listComment.Add(newComment);
            commentsService.CreateComment(_postId, _userIdLogin, cmt);
            UserDto userDto = authenticationService.GetUserByUserId(_userIdLogin);
            Image avatarCmt = Image.FromFile(userDto.Avatar);
            UCComments ucComments = new UCComments();
            string name = _name + " " + _lastname;
            ucComments.content(avatarCmt, name, cmt);
            flpCmtTable.Controls.Add(ucComments);
            txtInputCmt.Text = "";
        }



        public event EventHandler Profile1Clicked;
        public event EventHandler Profile2Clicked;
        public event EventHandler Choose1Clicked;
        public event EventHandler Choose2Clicked;
        public event EventHandler CLoseClieckedClicked;
        public event EventHandler AdjustOptionClicked;
        private void picAvatar_Click(object sender, EventArgs e)
        {
            OnProfile1Clicked();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            OnProfile2Clicked();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (flpChoose.Visible == true)
            {
                flpChoose.Visible = false;
            }
            else
            {
                flpChoose.Visible = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OnCLoseClieckedClicked();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OnChoose1Clicked();
        }
        protected virtual void OnProfile1Clicked()
        {
            Profile1Clicked?.Invoke(this, EventArgs.Empty);
        }        
        protected virtual void OnProfile2Clicked()
        {
            Profile2Clicked?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnChoose1Clicked()
        {
            Choose1Clicked?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnCLoseClieckedClicked()
        {
            CLoseClieckedClicked?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnAdjustOptionClicked()
        {
            AdjustOptionClicked?.Invoke(this, EventArgs.Empty);
        }


        private void btnShare_Click(object sender, EventArgs e)
        {
            shareService.AddShare(_postId, _userIdLogin);
            int numShare = int.Parse(_numShares);
            numShare++;
            lblShare.Text = numShare.ToString();
            PostingFrom posting = new PostingFrom(_postId, _media);
            posting.ShowDialog();
        }

        private void lblLike_Click(object sender, EventArgs e)
        {
            List<LikeLoveDto> likeLoveDtos = likeLoveService.GetLikeLoveByPostId(_postId);
            if (likeLoveDtos.Count > 0)
            {
                SeeLikeCmtPeople seelike = new SeeLikeCmtPeople(_postId);
                seelike.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Chỉnh sửa đối tượng")
            {
                OnAdjustOptionClicked();
                AdjustOptionForm adjustOptionForm = new AdjustOptionForm(_userIdLogin, _optionId, _postId);
                adjustOptionForm.ShowDialog();
                flpChoose.Visible = false;
            }
            else
            {

            }

        }
        public void SetOption(int optionId)
        {
            switch (optionId)
            {
                case 1:
                    lblOption.Text = "Công khai";
                    break;
                case 2:
                    lblOption.Text = "Bạn bè";
                    break;
                case 3:
                    lblOption.Text = "Bạn bè ngoại trừ";
                    break;
                case 4:
                    lblOption.Text = "Bạn bè cụ thể";
                    break;
                case 5:
                    lblOption.Text = "Chỉ mình tôi";
                    break;
                default:
                    lblOption.Text = "";
                    break;
            }
        }
    }
}
