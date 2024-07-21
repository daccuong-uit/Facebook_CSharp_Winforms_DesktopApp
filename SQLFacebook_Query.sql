USE FACEBOOK
USE SPOTIFY

--GET all data in all table
select * from USERS
select * from CONTACTS
select * from MESSAGES
select * from CHATS
select * from POSTS
select * from LIKELOVE
select * from COMMENTS
select * from SETTINGS
select * from SESSION
select * from FRIENDREQUESTS
select * from SELECTED_USERS
select * from SHARE


--DELETE all
delete from USERS
DBCC CHECKIDENT ('USERS', RESEED, 0)	
delete from CONTACTS
DBCC CHECKIDENT ('CONTACTS', RESEED, 0)
delete from MESSAGES
DBCC CHECKIDENT ('MESSAGES', RESEED, 0)
delete from POSTS
DBCC CHECKIDENT ('POSTS', RESEED, 0)
delete from CHATS
delete from SESSION
DBCC CHECKIDENT ('SESSION', RESEED, 0)
delete from LIKELOVE
DBCC CHECKIDENT ('LIKELOVE', RESEED, 0)
delete from FRIENDREQUESTS
DBCC CHECKIDENT ('FRIENDREQUESTS', RESEED, 0)
delete from COMMENTS
DBCC CHECKIDENT ('COMMENTS', RESEED, 0)
delete from SELECTED_USERS


INSERT INTO USERS (LastName, Name, Username, Email, PhoneNumber, Password, Avatar)
VALUES
  (N'Nguyễn Đắc', N'Cường', 'daccuong', 'nguyendaccuong12a4@gmail.com', '0356899602', '11032003', N'D:\_HocKi6\C#\MyApp\Facebook\GUI\Assets\Images\avatar.jpg'),
  (N'Phạm Thị', N'Ngoan', 'ngoanpham', 'ngoanpham1981@gmail.com', '012345679', '11032003', N'C:\Users\nguye\OneDrive\Hình ảnh\Theme\sky_theme.jpg'),
  (N'Nguyễn Thị', N'Thanh Nga', 'thanhnga', 'thanhnga2503@gmail.com', '012345678', '11032003', N'C:\Users\nguye\OneDrive\Hình ảnh\Image_ThanhNga\DSC05244.JPG');
INSERT INTO CONTACTS (UserId, ContactUserId)
VALUES
  (2, 1),
  (1, 2),
  (3, 1),
  (1, 3),
  (3, 2),
  (2, 3);

INSERT INTO SESSION (IsLoggedIn, UserId)
VALUES 
	(1, 1), 
	(1, 2),
	(1, 3);