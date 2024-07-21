USE FACEBOOK

-- Insert data in to Users table

-- Insert data in to Chats table

-- Insert data in to Messages table
  
-- Insert data in to Contacts table
INSERT INTO CONTACTS (UserId, ContactUserId)
SELECT DISTINCT UserId, ContactUserId
FROM (
    VALUES
      (1, 2),
	  (2, 1)
) AS TempTable(UserId, ContactUserId)
WHERE NOT EXISTS (
    SELECT 1
    FROM CONTACTS
    WHERE UserId = TempTable.UserId AND ContactUserId = TempTable.ContactUserId
)

INSERT INTO USERS (
  Name,
  LastName,
  Username,
  Email,
  PhoneNumber,
  Password,
  Avatar
)
VALUES (
  N'Nguyễn Đắc',
  N'Cường',
  'daccuong',
  'nguyendaccuong12a5@gmail.com',
  '0356899602',
  '12345678',
  'D:\_HocKi6\C#\MyApp\Facebook\GUI\Assets\Images\avatar.jpg'
);