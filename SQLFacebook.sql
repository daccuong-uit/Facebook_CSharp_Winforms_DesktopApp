CREATE DATABASE FACEBOOK
USE FACEBOOK

USE SPOTIFY

-- Tạo bảng "Users" để lưu trữ thông tin người dùng
CREATE TABLE USERS (
  UserId INT IDENTITY(1,1) PRIMARY KEY,
  LastName NVARCHAR(50),
  Name NVARCHAR(50),
  Username VARCHAR(50) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  PhoneNumber VARCHAR(50),
  Password VARCHAR(50) NOT NULL,
  Avatar NVARCHAR(MAX)
);

-- Tạo bảng "Chats" để lưu trữ thông tin cuộc trò chuyện
CREATE TABLE CHATS (
  ChatId INT PRIMARY KEY
);

-- Tạo bảng "Messages" để lưu trữ thông tin tin nhắn
CREATE TABLE MESSAGES (
  MessageId INT IDENTITY(1,1) PRIMARY KEY,
  ChatId INT,
  UserId INT,
  Content NVARCHAR(MAX),
  ContentImage NVARCHAR(MAX),
  ContentIcon NVARCHAR(MAX),
  ContentVideo NVARCHAR(MAX),
  SentAt DATETIME,
  FOREIGN KEY (ChatId) REFERENCES CHATS(ChatId),
  FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);

-- Tạo bảng "Contacts" để lưu trữ thông tin liên lạc
CREATE TABLE CONTACTS (
  ContactId INT IDENTITY(1,1) PRIMARY KEY,
  UserId INT,
  ContactUserId INT,
  FOREIGN KEY (UserId) REFERENCES USERS(UserId),
  FOREIGN KEY (ContactUserId) REFERENCES USERS(UserId)
);

CREATE TABLE POSTS (
    PostId INT IDENTITY(1,1) PRIMARY KEY,
    Caption NVARCHAR(MAX),
    OptionId INT,
    Media NVARCHAR(MAX),
    Statitude INT,
	Share INT,
    CreatedAt DATETIME,
    UserId INT,
    FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);

CREATE TABLE SHARE (
    ShareId INT IDENTITY(1,1) PRIMARY KEY,
    PostId INT,
    UserId INT,
    ShareTime DATETIME,
    FOREIGN KEY (PostId) REFERENCES POSTS(PostId),
    FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);

CREATE TABLE SELECTED_USERS (
    PostId INT,
    UserId INT,
    PRIMARY KEY (PostId, UserId),
    FOREIGN KEY (PostId) REFERENCES POSTS(PostId),
    FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);

CREATE TABLE COMMENTS (
    CommentId INT IDENTITY(1,1) PRIMARY KEY,
    PostId INT,
    UserCommentId INT,
    Content NVARCHAR(MAX),
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (PostId) REFERENCES POSTS(PostId),
    FOREIGN KEY (UserCommentId) REFERENCES USERS(UserId)
);

CREATE TABLE LIKELOVE (
    LikeId INT IDENTITY(1,1) PRIMARY KEY,
    PostId INT,
    UserLiketId INT,
    Content INT, -- 0 = Dislike, 1 = Like, 2 = Love
    FOREIGN KEY (PostId) REFERENCES POSTS(PostId),
    FOREIGN KEY (UserLiketId) REFERENCES USERS(UserId)
);

-- Tạo bảng "Groups" để lưu trữ thông tin nhóm
CREATE TABLE GROUPS (
  GroupId INT IDENTITY(1,1) PRIMARY KEY,
  GroupName VARCHAR(50),
  CreatedByUserId INT,
  CreatedAt DATETIME,
  FOREIGN KEY (CreatedByUserId) REFERENCES USERS(UserId)
);

-- Tạo bảng "GroupMembers" để lưu trữ thông tin thành viên nhóm
CREATE TABLE GROUPMEMBERS (
  GroupMemberId INT IDENTITY(1,1) PRIMARY KEY,
  GroupId INT,
  UserId INT,
  FOREIGN KEY (GroupId) REFERENCES GROUPS(GroupId),
  FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);

-- Tạo bảng "GroupMessages" để lưu trữ thông tin tin nhắn trong nhóm
CREATE TABLE GROUPMESSAGES (
  GroupMessageId INT IDENTITY(1,1) PRIMARY KEY,
  GroupId INT,
  UserId INT,
  Content VARCHAR(MAX),
  SentAt DATETIME,
  FOREIGN KEY (GroupId) REFERENCES GROUPS(GroupId),
  FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);

-- Tạo bảng "FriendRequests" để lưu trữ thông tin yêu cầu kết bạn
CREATE TABLE FRIENDREQUESTS (
  RequestId INT IDENTITY(1,1) PRIMARY KEY,
  SenderId INT,
  ReceiverId INT,
  Status INT,
  SendAt DATETIME,
  FOREIGN KEY (SenderId) REFERENCES USERS(UserId),
  FOREIGN KEY (ReceiverId) REFERENCES USERS(UserId)
);
-- Tạo bảng "Notifications" để lưu trữ thông tin thông báo
CREATE TABLE NOTIFICATIONS (
  NotificationId INT IDENTITY(1,1) PRIMARY KEY,
  UserId INT,
  Content VARCHAR(MAX),
  CreatedAt DATETIME,
  FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);

-- Tạo bảng "Settings" để lưu trữ thông tin cài đặt người dùng
CREATE TABLE SETTINGS (
  SettingId INT IDENTITY(1,1) PRIMARY KEY,
  UserId INT,
  NotificationEnabled BIT,
  Language VARCHAR(50),
  DarkMode BIT,
  FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);

-- Tạo bảng "Session" để lưu trữ thông tin người dùng đăng nhập
CREATE TABLE SESSION (
  SessionId INT IDENTITY(1,1) PRIMARY KEY,
  IsLoggedIn INT,
  UserId INT,
  FOREIGN KEY (UserId) REFERENCES USERS(UserId)
);
CREATE TABLE BLOCKEDUSERS (
  BlockedUserId INT IDENTITY(1,1) PRIMARY KEY,
  UserId INT,
  FOREIGN KEY (UserId) REFERENCES USERS(UserId),
);