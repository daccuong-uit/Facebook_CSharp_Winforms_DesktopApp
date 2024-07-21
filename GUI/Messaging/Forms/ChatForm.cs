using AxWMPLib;
using BLL.Services;
using DTO;
using GUI.AppSettings;
using GUI.Controls;
using GUI.Controls.ChatControls;
using GUI.Controls.StoreMediaControls;
using GUI.NewsFeed.Forms;
using GUI.UserManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WMPLib;

namespace GUI.Messaging.Forms
{
    public partial class ChatForm : BaseForm
    {
        AuthenticationService authenticationService;
        ContactService contactService;
        MessageService messageService;

        DataTable dtUserContact = null;
        DataTable dtChatMessages = null;
        DataTable dtContact = null;

        private int selectedContactUserID;
        private int sessionId;
        private int userIdLogin;
        UserDto loginUser;

        public ChatForm()
        {
            authenticationService = new AuthenticationService();
            contactService = new ContactService();
            messageService = new MessageService();
            loginUser = new UserDto();

            sessionId = SessionManager.GetSessionId();
            userIdLogin = SessionManager.GetuUserId(sessionId);

            InitializeComponent();
            LoadEmoClick();

            GetUser();
            GetContact();
            LoadUser();
            LoadContactUserData();
            SaveUserContactData();

            //Darkmode
            DarkMode.OnDarkModeChanged += DarkMode_OnDarkModeChanged;
            UpdateUIBasedOnDarkMode(DarkMode.IsDarkModeEnabled);

            //English
            Language.OnEnglishChanged += English_OnEnglishChanged;
            UpdateUIBasedOnEnglish(Language.IsEnglishEnabled);
        }

        #region -> Send messages
        private void picSend_Click(object sender, EventArgs e)
        {
            SendText();
        }
        private void txtChatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendText();
            }
        }

        //Sending
        int yChat = 15;
        private void SendText()
        {
            //Tạo contact nếu là lần đầu nhắn, tức là trong danh sách contact đếch có thằng contact này, nếu có rồi đếch cần tạo

            string message = txtChatBox.Text;
            Image imageAvatar = Image.FromFile(loginUser.Avatar);

            while (message.StartsWith("\n") || message.StartsWith("\r"))
            {
                message = message.Substring(1);
            }

            // Kiểm tra và xóa dấu xuống dòng ở cuối chuỗi
            while (message.EndsWith("\n") || message.EndsWith("\r"))
            {
                message = message.Substring(0, message.Length - 1);
            }

            ChatUsers chatUsers = new ChatUsers();
            chatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
            this.flpChatContent.Controls.Add(chatUsers);
            chatUsers.Content(imageAvatar, message, DateTime.Now.ToString("HH:mm tt"));
            chatUsers.Location = new System.Drawing.Point(100, yChat);
            double heightUser = 80;
            double height = 40;
            if (Convert.ToDouble(txtChatBox.Text.Length) > 55)
            {
                heightUser = 60 + 23 * Math.Round((Convert.ToDouble(txtChatBox.Text.Length) / 55) + 0.5);
            }  
            chatUsers.SetControlSize(460, Convert.ToInt32(height));
            chatUsers.Size = new System.Drawing.Size(800, Convert.ToInt32(heightUser));
            yChat = yChat + 15;
            txtChatBox.Text = "";
            //Lưu vào database
            SendMessage(userIdLogin, selectedContactUserID, message, null, null, null);
        }

        private List<Image> selectedImages = new List<Image>();
        private void picImage_Click(object sender, EventArgs e)
        {
            //Tạo contact nếu là lần đầu nhắn, tức là trong danh sách contact đếch có thằng contact này, nếu có rồi đếch cần tạo

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    Image image = Image.FromFile(filePath);
                    selectedImages.Add(image);
                    //Lưu vào database
                    SendMessage(userIdLogin, selectedContactUserID, null, image, null, null);
                }

                LoadSelectedImages();
                txtChatBox.Text = "";
            }

            selectedImages.Clear();
        }

        private void LoadSelectedImages()
        {
            foreach (Image image in selectedImages)
            {
                Image imageAvatar = Image.FromFile(loginUser.Avatar);
                ImageChatUsers imageChatUsers = new ImageChatUsers();
                this.flpChatContent.Controls.Add(imageChatUsers);
                imageChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);

                imageChatUsers.content(imageAvatar, image, DateTime.Now.ToString("HH:mm tt"));

                imageChatUsers.Location = new System.Drawing.Point(100, yChat);
                imageChatUsers.Size = new System.Drawing.Size(940, imageChatUsers.Height);

                yChat = yChat + 110;
            }
        }

        private void LoadEmoClick()
        {
            picEmo01.Image = Properties.Resources.emo01;
            picEmo02.Image = Properties.Resources.emo02;
            picEmo03.Image = Properties.Resources.emo03;
            picEmo04.Image = Properties.Resources.emo04;
            picEmo05.Image = Properties.Resources.emo05;
            picEmo06.Image = Properties.Resources.emo06;
            picEmo07.Image = Properties.Resources.emo07;
            picEmo08.Image = Properties.Resources.emo08;
            picEmo09.Image = Properties.Resources.emo09;
            picEmo10.Image = Properties.Resources.emo10;
            picEmo11.Image = Properties.Resources.emo11;
            picEmo12.Image = Properties.Resources.emo12;
            picEmo13.Image = Properties.Resources.emo13;
            picEmo14.Image = Properties.Resources.emo14;
            picEmo15.Image = Properties.Resources.emo15;
            picEmo16.Image = Properties.Resources.emo16;
            picEmo17.Image = Properties.Resources.emo17;
            picEmo18.Image = Properties.Resources.emo18;

            picEmo01.Click += new EventHandler(SendEmo);
            picEmo02.Click += new EventHandler(SendEmo);
            picEmo03.Click += new EventHandler(SendEmo);
            picEmo04.Click += new EventHandler(SendEmo);
            picEmo05.Click += new EventHandler(SendEmo);
            picEmo06.Click += new EventHandler(SendEmo);
            picEmo07.Click += new EventHandler(SendEmo);
            picEmo08.Click += new EventHandler(SendEmo);
            picEmo09.Click += new EventHandler(SendEmo);
            picEmo10.Click += new EventHandler(SendEmo);
            picEmo11.Click += new EventHandler(SendEmo);
            picEmo12.Click += new EventHandler(SendEmo);
            picEmo13.Click += new EventHandler(SendEmo);
            picEmo14.Click += new EventHandler(SendEmo);
            picEmo15.Click += new EventHandler(SendEmo);
            picEmo16.Click += new EventHandler(SendEmo);
            picEmo17.Click += new EventHandler(SendEmo);
            picEmo18.Click += new EventHandler(SendEmo);
        }

        private void SendEmo(object sender, EventArgs e)
        {
            //Tạo contact nếu là lần đầu nhắn, tức là trong danh sách contact đếch có thằng contact này, nếu có rồi đếch cần tạo

            Image imageAvatar = Image.FromFile(loginUser.Avatar);
            PictureBox a = (PictureBox)sender;
            IconChatUsers iconChatUsers = new IconChatUsers();
            iconChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
            this.flpChatContent.Controls.Add(iconChatUsers);
            iconChatUsers.content(imageAvatar, a.Image, DateTime.Now.ToString("HH:mm tt"));

            Image icon = a.Image;

            iconChatUsers.Location = new System.Drawing.Point(100, yChat);
            txtChatBox.Text = "";

            iconChatUsers.Size = new System.Drawing.Size(940, iconChatUsers.Height);

            yChat = yChat + 110;
            //Lưu vào database
            SendMessage(userIdLogin, selectedContactUserID,null, null, icon, null);
        }

        private List<string> selectedVideoPaths = new List<string>();

        private void picOption_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mp3";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string videoPath in openFileDialog.FileNames)
                {
                    Image imageAvatar = Image.FromFile(loginUser.Avatar);
                    selectedVideoPaths.Add(videoPath);

                    // Chuyển đổi tệp video thành mảng byte
                    string videoData = videoPath;

                    VideoChatUsers videoChatUsers = new VideoChatUsers();
                    this.flpChatContent.Controls.Add(videoChatUsers);
                    videoChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);

                    AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
                    windowsMediaPlayer.Size = new System.Drawing.Size(240, 240);
                    windowsMediaPlayer.Location = new System.Drawing.Point(70, 15);
                    videoChatUsers.Controls.Add(windowsMediaPlayer);
                    videoChatUsers.content(imageAvatar, DateTime.Now.ToString("HH:mm tt"));
                    windowsMediaPlayer.CreateControl();

                    videoChatUsers.Location = new System.Drawing.Point(100, yChat);
                    videoChatUsers.Size = new System.Drawing.Size(940, videoChatUsers.Height);

                    yChat = yChat + 110;
                    txtChatBox.Text = "";

                    windowsMediaPlayer.Ctlcontrols.stop();
                    windowsMediaPlayer.URL = videoPath;

                    // Lưu vào database
                    SendMessage(userIdLogin, selectedContactUserID, null, null, null, videoData);
                }
            }
        }
        #endregion

        #region -> Store messages, session, setting into Database
        public void SendMessage(int userId, int contactUserId, string content, Image contentImage, Image contentIcon, string contentVideo)
        {
            messageService.SendMessage(userId, contactUserId, content, contentImage.ToString(), contentIcon.ToString(), contentVideo);
        }
        #endregion

        #region -> Store messages, contactUser into File
        void SaveContact()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Contactuser", "UserContact.txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataRow row in dtContact.Rows)
                {
                    string contactId = row["contactId"].ToString();
                    string userId = row["userId"].ToString();
                    string contactUserId = row["contactUserId"].ToString();
                    // Ghi thông tin người liên hệ vào tệp tin
                    writer.WriteLine($"ContactId: {contactId}");
                    writer.WriteLine($"UserId: {userId}");
                    writer.WriteLine($"ContactUserId: {contactUserId}");
                    writer.WriteLine();
                }
            }
        }
        void SaveUserContactData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Contactuser", "UserContactData.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataRow row in dtUserContact.Rows)
                {
                    string userId = row["userId"].ToString();
                    string name = row["name"].ToString();
                    string lastName = row["lastName"].ToString();
                    string userName = row["userName"].ToString();
                    string email = row["email"].ToString();
                    string phoneNumber = row["phoneNumber"].ToString();
                    string password = row["password"].ToString();

                    // Ghi thông tin người liên hệ vào tệp tin
                    writer.WriteLine($"User ID: {userId}");
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Last Name: {lastName}");
                    writer.WriteLine($"Username: {userName}");
                    writer.WriteLine($"Email: {email}");
                    writer.WriteLine($"Phone Number: {phoneNumber}");
                    writer.WriteLine($"Password: {password}");
                    writer.WriteLine();
                }
            }
        }
        void SaveMessagesByChatId(int chatId)
        {
            string baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Messages");
            string imagesDirectory = Path.Combine(baseDirectory, "Images");
            string iconsDirectory = Path.Combine(baseDirectory, "Icons");
            string videosDirectory = Path.Combine(baseDirectory, "Videos");

            string fileName = $"Messages_{chatId}.txt";
            string filePath = Path.Combine(baseDirectory, fileName);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (DataRow row in dtChatMessages.Rows)
                {
                    int messageId = (int)row["messagesId"];
                    int rowChatId = (int)row["chatId"];
                    int userId = (int)row["userId"];

                    string content = row["content"] != DBNull.Value ? row["content"].ToString() : null;

                    byte[] contentImage = null;
                    if (!DBNull.Value.Equals(row["contentImage"]))
                    {
                        contentImage = (byte[])row["contentImage"];

                        string imageFileName = $"Image_{messageId}.jpg";
                        string imageFilePath = Path.Combine(imagesDirectory, imageFileName);
                        if (!File.Exists(imageFilePath))
                        {
                            File.WriteAllBytes(imageFilePath, contentImage);
                        }
                    }

                    byte[] contentIcon = null;
                    if (!DBNull.Value.Equals(row["contentIcon"]))
                    {
                        contentIcon = (byte[])row["contentIcon"];

                        string iconFileName = $"Icon_{messageId}.ico";
                        string iconFilePath = Path.Combine(iconsDirectory, iconFileName);
                        if (!File.Exists(iconFilePath))
                        {
                            File.WriteAllBytes(iconFilePath, contentIcon);
                        }
                    }

                    byte[] contentVideo = null;
                    if (!DBNull.Value.Equals(row["contentVideo"]))
                    {
                        contentVideo = (byte[])row["contentVideo"];

                        string videoFileName = $"Video_{messageId}.mp4";
                        string videoFilePath = Path.Combine(videosDirectory, videoFileName);
                        if (!File.Exists(videoFilePath))
                        {
                            File.WriteAllBytes(videoFilePath, contentVideo);
                        }
                    }

                    string sentAt = row["senAt"].ToString();

                    // Ghi thông tin tin nhắn vào tệp tin
                    writer.WriteLine($"Message ID: {messageId}");
                    writer.WriteLine($"Chat ID: {rowChatId}");
                    writer.WriteLine($"User ID: {userId}");

                    if (content != null)
                    {
                        writer.WriteLine($"Content: {content}");
                    }

                    if (contentImage != null)
                    {
                        string imageFileName = $"Image_{messageId}.jpg";
                        writer.WriteLine($"Content Image: {imageFileName}");
                    }

                    if (contentIcon != null)
                    {
                        string iconFileName = $"Icon_{messageId}.ico";
                        writer.WriteLine($"Content Icon: {iconFileName}");
                    }

                    if (contentVideo != null)
                    {
                        string videoFileName = $"Video_{messageId}.mp4";
                        writer.WriteLine($"Content Video: {videoFileName}");
                    }

                    writer.WriteLine($"Sent At: {sentAt}");
                    writer.WriteLine();
                }
            }
        }
        #endregion

        #region -> GET data
        // Lấy danh sách người liên hệ với người đã đăng nhập
        void GetContact()
        {
            dtContact = new DataTable();
            dtContact.Columns.Add("contactId", typeof(int));
            dtContact.Columns.Add("userId", typeof(int));
            dtContact.Columns.Add("contactUserId", typeof(int));

            List<ContactDto> contactDtos = contactService.GetContactsByUserId(userIdLogin);

            foreach (ContactDto contactDto in contactDtos)
            {
                DataRow row = dtContact.NewRow();
                row["contactId"] = contactDto.ContactId;
                row["userId"] = contactDto.UserId;
                row["contactUserId"] = contactDto.ContactUserId;
                dtContact.Rows.Add(row);
            }
            SaveContact();
        }

        //Lấy user đăng nhập
        void GetUser()
        {
            loginUser = authenticationService.GetUserByUserId(userIdLogin);
        }

        // Lấy danh sách chi tiết người liên hệ với người đã đăng nhập
        void GetUserContact()
        {
            dtUserContact = new DataTable();
            dtUserContact.Columns.Add("userId", typeof(int));
            dtUserContact.Columns.Add("name", typeof(string));
            dtUserContact.Columns.Add("lastName", typeof(string));
            dtUserContact.Columns.Add("userName", typeof(string));
            dtUserContact.Columns.Add("email", typeof(string));
            dtUserContact.Columns.Add("phoneNumber", typeof(string));
            dtUserContact.Columns.Add("password", typeof(string));
            dtUserContact.Columns.Add("avatar", typeof(Image));

            // Lấy thông tin người dùng theo userId của người liên hệ
            List<UserDto> contactUsers = new List<UserDto>();   

            foreach (DataRow contactRow in dtContact.Rows)
            {
                int contactUserId = (int)contactRow["ContactUserId"];

                UserDto userDto = authenticationService.GetUserByUserId(contactUserId);
                contactUsers.Add(userDto);

                // Thêm thông tin người liên hệ vào DataTable
                DataRow newRow = dtUserContact.NewRow();
                newRow["userId"] = userDto.UserId;
                newRow["name"] = userDto.Name;
                newRow["lastName"] = userDto.LastName;
                newRow["userName"] = userDto.UserName;
                newRow["email"] = userDto.Email;
                newRow["phoneNumber"] = userDto.PhoneNumber;
                newRow["password"] = userDto.Password;
                newRow["avatar"] = Image.FromFile(userDto.Avatar);
                dtUserContact.Rows.Add(newRow);
            }
        }

        // Lấy danh sách tin nhắn của user đã đăng nhập với CHatId cụ thể
        void GetMessagesByChatIdAndUserId()
        {
            dtChatMessages = new DataTable();
            dtChatMessages.Columns.Add("messagesId", typeof(int));
            dtChatMessages.Columns.Add("chatId", typeof(int));
            dtChatMessages.Columns.Add("userId", typeof(int));
            dtChatMessages.Columns.Add("content", typeof(string));
            dtChatMessages.Columns.Add("contentImage", typeof(byte[]));
            dtChatMessages.Columns.Add("contentIcon", typeof(byte[]));
            dtChatMessages.Columns.Add("contentVideo", typeof(byte[]));
            dtChatMessages.Columns.Add("senAt", typeof(DateTime));

            int chatId = GetChatIdFromDtContact(userIdLogin);

            List<MessageDto> messages = messageService.GetMessagesByChatIdAndUserId(chatId, userIdLogin);

            foreach (MessageDto message in messages)
            {
                dtChatMessages.Rows.Add(
                    message.MessageId,
                    message.ChatId,
                    message.UserId,
                    message.Content,
                    message.ContentImage,
                    message.ContentIcon,
                    message.ContentVideo,
                    message.SentAt
                );
            }
            SaveMessagesByChatId(chatId);
        }
        #endregion

        #region -> Get data from Datatable
        // Get chatId from dtContact
        int GetChatIdFromDtContact(int userId)
        {
            int contactUserId = selectedContactUserID;
            int chatId = 1;
            // Tìm ContactId từ dtContact với UserId và ContactUserId
            DataRow[] contactRows = dtContact.Select($"userId = {userId} AND contactUserId = {contactUserId}");
            if (contactRows.Length > 0)
            {
                chatId = (int)contactRows[0]["contactId"];
            }
            return chatId;
        }

        #endregion
        
        #region -> Display Data
        // Login user
        void LoadUser()
        {
            picAvatar.Image = Image.FromFile(loginUser.Avatar);
            customePicture1.Image = Image.FromFile(loginUser.Avatar);
            btnMyUser.Text = loginUser.LastName.ToString() + " " + loginUser.Name.ToString();
        }

        // Đưa các user vào danh sách người liên hệ
        void LoadContactUserData()
        {
            GetUserContact();
            GetMessagesByChatIdAndUserId();
            for (int i = 0; i < dtUserContact.Rows.Count; i++)
                FunctionContactUserData(i);

            // Mở sẵn một user
            if (flpListFriends.Controls.Count > 0)
            {
                MyUserControl firstUserControl = (MyUserControl)flpListFriends.Controls[0];
                userClick(firstUserControl, EventArgs.Empty);
            }
        }
        void FunctionContactUserData(int ID)
        {
            MyUserControl user = new MyUserControl();
            user.LoadDataUser((int)dtUserContact.Rows[ID]["userId"], (string)(dtUserContact.Rows[ID]["name"]), (string)(dtUserContact.Rows[ID]["lastName"]), (string)dtUserContact.Rows[ID]["userName"], (Image)dtUserContact.Rows[ID]["avatar"]);
            user.Click += new EventHandler(userClick);
            flpListFriends.Controls.Add(user);
        }

        private void userClick(object sender, EventArgs e)
        {
            MyUserControl user = (MyUserControl)sender;
            selectedContactUserID = user.userID;
            string text = "userId=" + user.userID;
            DataRow[] selectedRows = dtUserContact.Select(text);
            if (selectedRows.Length > 0)
            {
                DataRow selectedRow = selectedRows[0];
                picAvatarContact.Image = (Image)selectedRow["avatar"];
                customePicture3.Image = (Image)selectedRow["avatar"];
                lblDetailContactName.Text = selectedRow["name"].ToString() + " " + selectedRow["lastName"].ToString();

                lblUserNameContact.Text = selectedRow["name"].ToString() + " " + selectedRow["lastName"].ToString();

                ClearChatContent();
                ClearStore();
                GetMessagesByChatIdAndUserId();

                foreach (DataRow messageRow in dtChatMessages.Rows)
                {
                    // Tạo và thêm các điều khiển hiển thị tin nhắn vào flpChatContent
                    if (messageRow[3] != null && messageRow[3].ToString().Length > 0)
                    {
                        string message = messageRow[3].ToString();
                        Image imageAvatar = Image.FromFile(loginUser.Avatar);

                        ChatUsers chatUsers = new ChatUsers();
                        chatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
                        this.flpChatContent.Controls.Add(chatUsers);
                        chatUsers.Content(imageAvatar, message, messageRow[7].ToString());
                        chatUsers.Location = new System.Drawing.Point(100, yChat);
                        double heightUser = 80;
                        double height = 40;
                        if (Convert.ToDouble(message.Length) > 50)
                        {
                            heightUser = 60 + 23 * Math.Round((Convert.ToDouble(message.Length) / 50) + 0.5);
                        }
                        chatUsers.SetControlSize(460, Convert.ToInt32(height));
                        chatUsers.Size = new System.Drawing.Size(800, Convert.ToInt32(heightUser));
                        yChat = yChat + 15;
                    }
                    string imageData = messageRow[4] as string;
                    if (imageData != null)
                    {
                        Image imageAvatar = Image.FromFile(loginUser.Avatar);
                        Image image = Image.FromFile(imageData);
                        ImageChatUsers imageChatUsers = new ImageChatUsers();
                        this.flpChatContent.Controls.Add(imageChatUsers);
                        imageChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);

                        ImageStore imageStore = new ImageStore();
                        this.flpImage.Controls.Add(imageStore);
                        imageStore.content(image, messageRow[7].ToString());
                        imageStore.DarkMode(DarkMode.IsDarkModeEnabled);

                        imageChatUsers.content(imageAvatar, image, messageRow[7].ToString());

                        imageChatUsers.Location = new System.Drawing.Point(100, yChat);
                        imageChatUsers.Size = new System.Drawing.Size(940, imageChatUsers.Height);

                        yChat = yChat + 110;
                    }
                    string iconData = messageRow[5] as string;
                    if (iconData != null && iconData.Length > 0)
                    {
                        Image imageAvatar = Image.FromFile(loginUser.Avatar);
                        Image icon = Image.FromFile(iconData);
                        IconChatUsers iconChatUsers = new IconChatUsers();
                        this.flpChatContent.Controls.Add(iconChatUsers);
                        iconChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);

                        iconChatUsers.content(imageAvatar, icon, messageRow[7].ToString());

                        iconChatUsers.Location = new System.Drawing.Point(100, yChat);
                        txtChatBox.Text = "";

                        iconChatUsers.Size = new System.Drawing.Size(940, iconChatUsers.Height);

                        yChat = yChat + 110;
                    }
                    string videoData = messageRow[6] as string;
                    if (videoData != null && videoData.Length > 0)
                    {
                        string videoFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Messages", "Videos", $"Video_{messageRow[0]}.mp4");
                        if (File.Exists(videoFilePath))
                        {
                            Image imageAvatar = Image.FromFile(loginUser.Avatar);

                            VideoChatUsers videoChatUsers = new VideoChatUsers();
                            this.flpChatContent.Controls.Add(videoChatUsers);
                            videoChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);

                            AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
                            windowsMediaPlayer.Size = new System.Drawing.Size(240, 240);
                            windowsMediaPlayer.Location = new System.Drawing.Point(70, 15);
                            videoChatUsers.Controls.Add(windowsMediaPlayer);
                            videoChatUsers.content(imageAvatar, messageRow[7].ToString());
                            windowsMediaPlayer.CreateControl();

                            videoChatUsers.Location = new System.Drawing.Point(100, yChat);
                            videoChatUsers.Size = new System.Drawing.Size(940, videoChatUsers.Height);

                            yChat = yChat + 110;

                            windowsMediaPlayer.Ctlcontrols.stop();
                            windowsMediaPlayer.URL = videoFilePath;
                            windowsMediaPlayer.Ctlcontrols.stop();
                        }
                    }
                                        
                    if (videoData != null && videoData.Length > 0)
                    {
                        string videoFilePath = Path.Combine(Application.StartupPath, "Data", "Messages", "Videos", $"Video_{messageRow[0]}.mp4");
                        if (File.Exists(videoFilePath))
                        {
                            VideoStore videoStore = new VideoStore();
                            this.flpVideo.Controls.Add(videoStore);
                            videoStore.DarkMode(DarkMode.IsDarkModeEnabled);

                            //AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
                            //windowsMediaPlayer.Size = new System.Drawing.Size(290, 220);
                            //windowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
                            //videoStore.Controls.Add(windowsMediaPlayer);
                            //windowsMediaPlayer.CreateControl();

                            videoStore.Location = new System.Drawing.Point(0, 0);
                            videoStore.Size = new System.Drawing.Size(290, 220);
                            videoStore.content(messageRow[7].ToString(), videoFilePath);

                            yChat = yChat + 110;
                            //axWindowsMediaPlayer1.URL = videoFilePath;
                            //windowsMediaPlayer.URL = videoFilePath; //thứ 2 hỏi cô cách hiển thị 2 video trên panel khác nhau và cách tắt video trước khi chuyển qua user khác
                            //Done
                        }
                    }
                }
            }
        }

        // Làm trống các panel trước khi chèn data
        private void ClearChatContent()
        {
            flpChatContent.Controls.Clear();
        }
        private void ClearStore()
        {
            flpImage.Controls.Clear();
            flpVideo.Controls.Clear();
        }
        #endregion

        #region -> Features
        private void txtSearchText_MouseEnter(object sender, EventArgs e)
        {
            txtSearchText.Text = "";
        }
        private void btnSearchText_Click(object sender, EventArgs e)
        {
            SerachText();
        }
        private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SerachText();
            }
        }
        void SerachText()
        {
            ResetBackColor();
            string searchText = txtSearchText.Text;
            while (searchText.StartsWith("\n") || searchText.StartsWith("\r"))
            {
                searchText = searchText.Substring(1);
            }
            while (searchText.EndsWith("\n") || searchText.EndsWith("\r"))
            {
                searchText = searchText.Substring(0, searchText.Length - 1);
            }

            int isSearch = 0;
            foreach (Control control in flpChatContent.Controls)
            {
                if (control is ChatUsers)
                {
                    ChatUsers chatUsers = (ChatUsers)control;
                    RichTextBox richText = chatUsers.GetTextBox();
                    string text = richText.Text;

                    //int index = richText.Text.IndexOf(searchText);
                    int index = -1;

                    while ((index = text.IndexOf(searchText, index + 1, StringComparison.OrdinalIgnoreCase)) >= 0)
                    {
                        richText.Select(index, searchText.Length);
                        richText.SelectionBackColor = ColorTranslator.FromHtml("#1877f2");
                        isSearch += 1;
                    }

                    //txtSearchText.Text = "";
                    //if (index >= 0)
                    //{
                    //    richText.SelectionStart = index;
                    //    richText.SelectionLength = searchText.Length;
                    //    richText.SelectionBackColor = ColorTranslator.FromHtml("#1877f2");
                    //    isSearch += 1;
                    //}
                }
            }
            if (isSearch == 0)
            {
                lblResultSearchText.Visible = true;
            }
            else
            {
                lblResultSearchText.Visible = false;
            }
            txtSearchText.Text = searchText.Substring(1);

        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            ResetBackColor();
        }
        void ResetBackColor()
        {
            foreach (Control control in flpChatContent.Controls)
            {
                if (control is ChatUsers)
                {
                    ChatUsers chatUsers = (ChatUsers)control;
                    RichTextBox textBox = chatUsers.GetTextBox();
                    if (DarkMode.IsDarkModeEnabled)
                    {
                        textBox.SelectionBackColor = ColorTranslator.FromHtml("#242526");
                    }
                    else
                    {
                        textBox.SelectionBackColor = ColorTranslator.FromHtml("#ffffff");
                    }
                }
            }
            lblResultSearchText.Visible = false;
        }
        #endregion

        #region -> Support method
        #endregion

        #region -> Controls
        private void picIcon_Click(object sender, EventArgs e)
        {
            if(flpEmo.Visible == false)
            {
                flpEmo.Visible = true;
            }
            else
            {
                flpEmo.Visible = false;
            }
        }

        private void picFeature_Click(object sender, EventArgs e)
        {
            if(pnlFeature.Visible == false)
            {
                pnlFeature.Visible = true;
                pnlFeature2.Visible = true;

                //MessList
                pnlMessengerMini.Size = new System.Drawing.Size(77, pnlMessengerMini.Height);
                lblTextChat.Size = new System.Drawing.Size(80, 65);
                lblTextChat.Location = new System.Drawing.Point(3,0);
                txtSearchInMess.Visible = false;
                btnMessageBox.Visible = false;
                flpListFriends.Location = new System.Drawing.Point(7, 100);

                pnlContent.Location = new System.Drawing.Point(77, 90);
                pnlContent.Size = new System.Drawing.Size(pnlContent.Size.Width - 40 - 77, pnlContent.Size.Height);

                lblGoToMessenger.Visible = false;
            }
            else
            {
                pnlFeature.Visible = false;
                pnlFeature2.Visible = false;
                pnlMessengerMini.Visible = true;

                //MessList
                pnlMessengerMini.Size = new System.Drawing.Size(310, pnlMessengerMini.Height);
                lblTextChat.Size = new System.Drawing.Size(120, 35);
                txtSearchInMess.Visible = true;
                btnMessageBox.Visible = true;
                flpListFriends.Location = new System.Drawing.Point(0, 140);

                pnlContent.Location = new System.Drawing.Point(310, 90);
                pnlContent.Size = new System.Drawing.Size(pnlContent.Size.Width + 40 + 77, pnlContent.Size.Height);

                lblGoToMessenger.Visible = true;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        //Open setting dialog
        private void customePicture1_Click(object sender, EventArgs e)
        {
            if(pnlUser.Visible == false) 
            {
                pnlUser.Visible = true;
            }
            else
            {
                pnlUser.Visible = false;
            }    
        }

        // Open Search text
        private void ResetFeature()
        {
            pnlSearchText.Visible = false;
            flpImage.Visible = false;
            flpVideo.Visible = false;

            btnVideoDetail.Location = new System.Drawing.Point(17, 215);
            btnSearchTextDetail.Location = new System.Drawing.Point(17, 249);

            lblResultSearchText.Visible = false;
        }
        private void btnSearchTextDetail_Click(object sender, EventArgs e)
        {
            if (pnlSearchText.Visible == false)
            {
                ResetFeature();
                pnlSearchText.Visible = true;
            }
            else
            {
                ResetFeature();
            }
        }

        //450, 490
        private void btnImageDetail_Click(object sender, EventArgs e)
        {
            if (flpImage.Visible == false)
            {
                ResetFeature();
                flpImage.Visible = true;
                btnVideoDetail.Location = new System.Drawing.Point(17, 477);
                btnSearchTextDetail.Location = new System.Drawing.Point(17, 517);
            }
            else
            {
                ResetFeature();
            }
        }
        //490
        private void btnVideoDetail_Click(object sender, EventArgs e)
        {
            if (flpVideo.Visible == false)
            {
                ResetFeature();
                flpVideo.Visible = true;
                btnSearchTextDetail.Location = new System.Drawing.Point(17, 517);
            }
            else
            {
                ResetFeature();
            }
        }
        //Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Logout(userIdLogin);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
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

                btnImageDetail.Text = "Image";
                btnVideoDetail.Text = "Video";
                btnSearchTextDetail.Text = "Search text";
                btnSearchText.Text = "Search";
                lblResultSearchText.Text = "Not found";
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

                btnImageDetail.Text = "Hình ảnh đã gửi";
                btnVideoDetail.Text = "Video đã gửi";
                btnSearchTextDetail.Text = "Tìm kiếm văn bản";
                btnSearchText.Text = "Tìm kiếm";
                lblResultSearchText.Text = "Không tìm thấy văn bản";
            }
        }
        #endregion

        #region -> Dark Mode
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if( DarkMode.IsDarkModeEnabled == false)
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
        //#ffffff #f6f7f8 #dcdcdc #f0f8ff #1877f2
        //#18191a #242526 #3a3b3c #1877f2 #ffffff
        private void UpdateUIBasedOnDarkMode(bool isDarkModeEnabled)
        {
            if (isDarkModeEnabled == true)
            {
                // Áp dụng các thay đổi cho Dark Mode
                windowControls.BackColor = ColorTranslator.FromHtml("#1877f2");
                windowControls.DarkMode(DarkMode.IsDarkModeEnabled);
                // ControlTab
                pnlControlTab.BackColor = ColorTranslator.FromHtml("#18191a");
                btnAnouncement.BackColor = ColorTranslator.FromHtml("#1877f2");
                // Chat
                pnlContent.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                flpEmo.BackColor = ColorTranslator.FromHtml("#242526");
                    //top
                pnlTitle2.BackColor = ColorTranslator.FromHtml("#18191a");
                pnlTitle.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                lblUserNameContact.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    //Mid
                flpChatContent.BackColor = ColorTranslator.FromHtml("#242526");
                foreach (Control control in flpChatContent.Controls)
                {
                    if (control is ChatUsers userControl)
                    {
                        userControl.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                    if (control is ImageChatUsers imageChatUsers)
                    {
                        imageChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                    if (control is IconChatUsers iconChatUsers)
                    {
                        iconChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                    if (control is VideoChatUsers videoChatUsers)
                    {
                        videoChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                }
                //Bot
                pnlChatBar.BackColor = ColorTranslator.FromHtml("#18191a");
                txtChatBox.BackColor = ColorTranslator.FromHtml("#18191a");
                pnlInputText.BackColor = ColorTranslator.FromHtml("#18191a");
                txtChatBox.ForeColor = ColorTranslator.FromHtml("#ffffff");

                // MessengerMini
                pnlMessengerMini.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                pnlMessengerMini2.BackColor = ColorTranslator.FromHtml("#18191a");

                btnOptional.Image = Properties.Resources._16_white_option;
                btnNewChatMini.Image = Properties.Resources._16_white_write;

                lblTextChat.ForeColor = ColorTranslator.FromHtml("#ffffff");
                txtSearchInMess.BackColor = ColorTranslator.FromHtml("#3a3b3c");
                txtSearchInMess.BorderColor = ColorTranslator.FromHtml("#3a3b3c");

                btnMessageBox.BackColor = ColorTranslator.FromHtml("#1877f2");
                btnMessageBox.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnComunication.BackColor = ColorTranslator.FromHtml("#1877f2");
                btnComunication.ForeColor = ColorTranslator.FromHtml("#ffffff");

                pnlGoToMess.BackColor = ColorTranslator.FromHtml("#18191a");

                foreach (Control control in flpListFriends.Controls)
                {
                    if (control is MyUserControl myUserControl)
                    {
                        myUserControl.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                }

                // Feature
                pnlFeature2.BackColor = ColorTranslator.FromHtml("#18191a");
                pnlFeature.BackColor = ColorTranslator.FromHtml("#3a3b3c");

                lblDetailContactName.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnImageDetail.BackColor = ColorTranslator.FromHtml("#18191a");
                btnVideoDetail.BackColor = ColorTranslator.FromHtml("#18191a");

                btnSearchTextDetail.BackColor = ColorTranslator.FromHtml("#18191a");
                pnlSearchText.BackColor = ColorTranslator.FromHtml("#18191a");
                pnlSerachtext.BackColor = ColorTranslator.FromHtml("#18191a");
                pnlSerachtext.BorderColor = ColorTranslator.FromHtml("#3a3b3c");
                txtSearchText.BackColor = ColorTranslator.FromHtml("#18191a");
                txtSearchText.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btnSearchText.BackColor = ColorTranslator.FromHtml("#1877f2");
                btnSearchText.ForeColor = ColorTranslator.FromHtml("#ffffff");
                lblResultSearchText.ForeColor = ColorTranslator.FromHtml("#ffffff");
                lblSearchText.ForeColor = ColorTranslator.FromHtml("#ffffff");

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
                // Áp dụng các thay đổi cho Light Mode
                // Áp dụng các thay đổi cho Dark Mode
                windowControls.BackColor = ColorTranslator.FromHtml("#ffffff");
                windowControls.DarkMode(DarkMode.IsDarkModeEnabled);
                // ControlTab
                pnlControlTab.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnAnouncement.BackColor = ColorTranslator.FromHtml("#ffffff");
                // Chat
                pnlContent.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                flpEmo.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                    //top
                pnlTitle2.BackColor = ColorTranslator.FromHtml("#ffffff");
                pnlTitle.BackColor = ColorTranslator.FromHtml("#dcdcdc");
                lblUserNameContact.ForeColor = ColorTranslator.FromHtml("#000000");
                    //Mid
                flpChatContent.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                foreach (Control control in flpChatContent.Controls)
                {
                    if (control is ChatUsers userControl)
                    {
                        userControl.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                    if (control is ImageChatUsers imageChatUsers)
                    {
                        imageChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                    if (control is IconChatUsers iconChatUsers)
                    {
                        iconChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                    if (control is VideoChatUsers videoChatUsers)
                    {
                        videoChatUsers.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                }
                    //Bot
                pnlChatBar.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtChatBox.BackColor = ColorTranslator.FromHtml("#ffffff");
                pnlInputText.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtChatBox.ForeColor = ColorTranslator.FromHtml("#000000");

                // MessengerMini
                pnlMessengerMini.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                pnlMessengerMini2.BackColor = ColorTranslator.FromHtml("#ffffff");

                btnOptional.Image = Properties.Resources._16_black_option;
                btnNewChatMini.Image = Properties.Resources._16_black_write;

                lblTextChat.ForeColor = ColorTranslator.FromHtml("#000000");
                txtSearchInMess.BackColor = ColorTranslator.FromHtml("#f6f7f8");
                txtSearchInMess.BorderColor = ColorTranslator.FromHtml("#f6f7f8");

                btnMessageBox.BackColor = ColorTranslator.FromHtml("#f0f8ff");
                btnMessageBox.ForeColor = ColorTranslator.FromHtml("#1877f2");
                btnComunication.BackColor = ColorTranslator.FromHtml("#f0f8ff");
                btnComunication.ForeColor = ColorTranslator.FromHtml("#1877f2");

                pnlGoToMess.BackColor = ColorTranslator.FromHtml("#ffffff");

                foreach (Control control in flpListFriends.Controls)
                {
                    if (control is MyUserControl myUserControl)
                    {
                        myUserControl.DarkMode(DarkMode.IsDarkModeEnabled);
                    }
                }

                // Feature
                pnlFeature2.BackColor = ColorTranslator.FromHtml("#ffffff");
                pnlFeature.BackColor = ColorTranslator.FromHtml("#f6f7f8");

                lblDetailContactName.ForeColor = ColorTranslator.FromHtml("#000000");
                btnImageDetail.BackColor = ColorTranslator.FromHtml("#ffffff");
                btnVideoDetail.BackColor = ColorTranslator.FromHtml("#ffffff");

                btnSearchTextDetail.BackColor = ColorTranslator.FromHtml("#ffffff");
                pnlSearchText.BackColor = ColorTranslator.FromHtml("#ffffff");
                pnlSerachtext.BackColor = ColorTranslator.FromHtml("#ffffff");
                pnlSerachtext.BorderColor = ColorTranslator.FromHtml("#dcdcdc");
                txtSearchText.BackColor = ColorTranslator.FromHtml("#ffffff");
                txtSearchText.ForeColor = ColorTranslator.FromHtml("#000000");
                btnSearchText.BackColor = ColorTranslator.FromHtml("#f0f8ff");
                btnSearchText.ForeColor = ColorTranslator.FromHtml("#1877f2");
                lblResultSearchText.ForeColor = ColorTranslator.FromHtml("#000000");
                lblSearchText.ForeColor = ColorTranslator.FromHtml("#000000");

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

    }
}
