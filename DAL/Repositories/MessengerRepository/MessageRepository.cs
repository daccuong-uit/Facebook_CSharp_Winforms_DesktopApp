using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Sửa lại SendAt thành DateTime, cho hiện ngày tháng

namespace DAL.Repositories
{
    public class MessageRepository
    {
        private readonly string connectionString;

        public MessageRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }

        // getMessagesByChatIdAndUserId(chatId, UserId): Lấy danh sách tin nhắn của user trong 1 cuộc trò chuyện cụ thể
        public List<Message> GetMessagesByChatIdAndUserId(int chatId, int userId)
        {
            List<Message> messages = new List<Message>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MessageId, ChatId, UserId, Content, ContentImage, ContentIcon, ContentVideo, SentAt FROM MESSAGES WHERE ChatId = @ChatId and UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChatId", chatId);
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Message message = new Message();
                            message.MessageId = (int)reader["MessageId"];
                            message.ChatId = (int)reader["ChatId"];
                            message.UserId = (int)reader["UserId"];
                            if (reader["Content"] != DBNull.Value)
                                message.Content = (string)reader["Content"];
                            if (reader["ContentImage"] != DBNull.Value)
                                message.ContentImage = (byte[])reader["ContentImage"]; 
                            if (reader["ContentIcon"] != DBNull.Value)
                                message.ContentIcon = (byte[])reader["ContentIcon"];
                            if (reader["ContentVideo"] != DBNull.Value)
                                message.ContentVideo = (byte[])reader["ContentVideo"];
                            message.SentAt = (DateTime)reader["SentAt"];

                            messages.Add(message);
                        }
                    }
                }
            }
            return messages;
        }

        // getMessagesByChatId(chatId): Lấy danh sách tin nhắn trong một cuộc trò chuyện dựa trên ID cuộc trò chuyện.
        /*public List<Message> GetMessagesByChatId(int chatId)
        {
            List<Message> messages = new List<Message>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MessageId, ChatId, UserId, Content, ContentImage, ContentVideo, SentAt FROM MESSAGES WHERE ChatId = @ChatId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChatId", chatId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Message message = new Message();
                            message.MessageId = (int)reader["MessageId"];
                            message.ChatId = (int)reader["ChatId"];
                            message.UserId = (int)reader["UserId"];
                            message.Content = (string)reader["Content"];
                            message.ContentImage = (byte[])reader["ContentImage"];
                            message.ContentVideo = (byte[])reader["ContentVideo"];
                            message.SentAt = (DateTime)reader["SentAt"];

                            messages.Add(message);
                        }
                    }
                }
            }

            return messages;
        }*/

        // getMessagesByUserId(userId): Lấy danh sách tin nhắn của một người dùng dựa trên ID người dùng.
        /*public List<Message> GetMessagesByUserId(int userId)
        {
            List<Message> messages = new List<Message>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MessageId, ChatId, UserId, Content, ContentImage, ContentVideo, SentAt FROM MESSAGES WHERE UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Message message = new Message();
                            message.MessageId = (int)reader["MessageId"];
                            message.ChatId = (int)reader["ChatId"];
                            message.UserId = (int)reader["UserId"];
                            message.Content = (string)reader["Content"];
                            message.ContentImage = (byte[])reader["ContentImage"];
                            message.ContentVideo = (byte[])reader["ContentVideo"];
                            message.SentAt = (DateTime)reader["SentAt"];

                            messages.Add(message);
                        }
                    }
                }
            }

            return messages;
        }*/

        // sendMessage(chatId, userId, content): Gửi một tin nhắn trong cuộc trò chuyện, với thông tin về ID cuộc trò chuyện, ID người dùng và nội dung tin nhắn.
        public void SendMessage(int userId, int contactUserId, string content, string contentImage, string contentIcon, string contentVideo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get ChatId using the query
                int chatId;
                string insertChatQuery = "INSERT INTO CHATS (ChatId) SELECT @ChatId WHERE NOT EXISTS (SELECT 1 FROM CHATS WHERE ChatId = @ChatId)";
                //string contactQuery = "SELECT MIN(ContactId) FROM CONTACTS WHERE (UserId = @UserId AND ContactUserId = @ContactUserId) OR (UserId = @ContactUserId AND ContactUserId = @UserId)";
                string contactQuery = "SELECT ContactId FROM CONTACTS WHERE (UserId = @UserId AND ContactUserId = @ContactUserId)";

                using (SqlCommand contactCommand = new SqlCommand(contactQuery, connection))
                {
                    contactCommand.Parameters.AddWithValue("@UserId", userId);
                    contactCommand.Parameters.AddWithValue("@ContactUserId", contactUserId);

                    var contactId = contactCommand.ExecuteScalar();
                    if (contactId != null && contactId != DBNull.Value)
                    {
                        chatId = (int)contactId;
                    }
                    else
                    {
                        throw new Exception("Contact doesn't exist.");
                    }

                    using (SqlCommand insertChatCommand = new SqlCommand(insertChatQuery, connection))
                    {
                        insertChatCommand.Parameters.AddWithValue("@ChatId", chatId);
                        insertChatCommand.ExecuteNonQuery();
                    }
                }
                // Insert the message with ChatId into the MESSAGES table
                string insertQuery = "INSERT INTO MESSAGES (ChatId, UserId, Content, ContentImage, ContentIcon, ContentVideo, SentAt) VALUES (@ChatId, @UserId, @Content, CONVERT(varbinary(max), @ContentImage), CONVERT(varbinary(max), @ContentIcon), CONVERT(varbinary(max), @ContentVideo), @SentAt)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ChatId", chatId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    if (content == null)
                    {
                        command.Parameters.AddWithValue("@Content", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Content", content);
                    }
                    if (string.IsNullOrEmpty(contentImage))
                    {
                        command.Parameters.AddWithValue("@ContentImage", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ContentImage", contentImage);
                    }
                    if (string.IsNullOrEmpty(contentIcon))
                    {
                        command.Parameters.AddWithValue("@ContentIcon", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ContentIcon", contentIcon);
                    }
                    if (string.IsNullOrEmpty(contentVideo))
                    {
                        command.Parameters.AddWithValue("@ContentVideo", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ContentVideo", contentVideo);
                    }
                    command.Parameters.AddWithValue("@SentAt", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
        }

        // deleteMessage(messageId): Xóa một tin nhắn dựa trên ID tin nhắn.
        /*public void DeleteMessage(int messageId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM MESSAGES WHERE MessageId = @MessageId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MessageId", messageId);

                    command.ExecuteNonQuery();
                }
            }
        }*/
    }
}