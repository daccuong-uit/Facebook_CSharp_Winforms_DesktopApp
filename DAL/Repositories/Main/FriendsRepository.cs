using DAL.Models.Main;
using DTO.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Main
{
    public class FriendsRepository
    {
        private readonly string connectionString;

        public FriendsRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }

        // Gửi lời mời kết bạn
        public void SendFriendRequest(int senderId, int receiverId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra xem cặp người gửi và người nhận đã tồn tại chưa
                string checkQuery = "SELECT COUNT(*) FROM FRIENDREQUESTS WHERE SenderId = @SenderId AND ReceiverId = @ReceiverId OR ReceiverId = @SenderId AND SenderId = @ReceiverId";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@SenderId", senderId);
                checkCommand.Parameters.AddWithValue("@ReceiverId", receiverId);
                int existingCount = (int)checkCommand.ExecuteScalar();

                if (existingCount == 0)
                {
                    // Nếu chưa tồn tại, thực hiện lệnh INSERT
                    string insertQuery = "INSERT INTO FRIENDREQUESTS (SenderId, ReceiverId, Status, SendAt) VALUES (@SenderId, @ReceiverId, 0, CURRENT_TIMESTAMP)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@SenderId", senderId);
                    insertCommand.Parameters.AddWithValue("@ReceiverId", receiverId);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        // Chấp nhận lời mời kết bạn
        public void AcceptFriendRequest(int requestId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE FRIENDREQUESTS SET Status = 1 WHERE RequestId = @RequestId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RequestId", requestId);
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFriend(int sender, int receiver)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE FRIENDREQUESTS SET Status = 0 WHERE Sender = @Sender AND Receiver = @Receiver";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Sender", sender);
                command.Parameters.AddWithValue("@Receiver", receiver);
                command.ExecuteNonQuery();
            }
        }

        // Từ chối lời mời kết bạn
        public void RejectFriendRequest(int requestId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM FRIENDREQUESTS WHERE RequestId = @RequestId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RequestId", requestId);
                command.ExecuteNonQuery();
            }
        }

        public List<FriendRequest> GetFriendsList(int currentUserId)
        {
            List<FriendRequest> friendsList = new List<FriendRequest>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT fr.RequestId, fr.SenderId, fr.ReceiverId, fr.Status, fr.SendAt " +
                               "FROM FRIENDREQUESTS fr " +
                               "WHERE fr.Status = 1 AND (fr.SenderId = @currentUserId OR fr.ReceiverId = @currentUserId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currentUserId", currentUserId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FriendRequest friend = new FriendRequest
                    {
                        RequestId = (int)reader["RequestId"],
                        SenderId = (int)reader["SenderId"],
                        ReceiverId = (int)reader["ReceiverId"],
                        Status = (int)reader["Status"],
                        SendAt = (DateTime)reader["SendAt"]
                    };
                    friendsList.Add(friend);
                }
            }
            return friendsList;
        }
        public List<int> GetFriendsIds(int currentUserId)
        {
            List<int> friendsIds = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT fr.SenderId, fr.ReceiverId " +
                               "FROM FRIENDREQUESTS fr " +
                               "WHERE fr.Status = 1 AND (fr.SenderId = @currentUserId OR fr.ReceiverId = @currentUserId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currentUserId", currentUserId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int senderId = (int)reader["SenderId"];
                    int receiverId = (int)reader["ReceiverId"];
                    if (senderId == currentUserId)
                    {
                        friendsIds.Add(receiverId);
                    }
                    else
                    {
                        friendsIds.Add(senderId);
                    }
                }
            }
            return friendsIds;
        }

        // Lấy danh sách các lời mời kết bạn đang chờ
        public List<FriendRequest> GetPendingFriendRequests(int currentUserId)
        {
            List<FriendRequest> pendingRequests = new List<FriendRequest>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT RequestId, SenderId, ReceiverId, Status, SendAt " +
                               "FROM FRIENDREQUESTS " +
                               "WHERE ReceiverId = @currentUserId AND Status = 0";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@currentUserId", currentUserId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    FriendRequest request = new FriendRequest
                    {
                        RequestId = (int)reader["RequestId"],
                        SenderId = (int)reader["SenderId"],
                        ReceiverId = (int)reader["ReceiverId"],
                        Status = (int)reader["Status"],
                        SendAt = (DateTime)reader["SendAt"]
                    };
                    pendingRequests.Add(request);
                }
            }
            return pendingRequests;
        }
        // Get RequestId based on SenderId and ReceiverId
        public int GetRequestIdBySenderAndReceiver(int senderId, int receiverId)
        {
            int requestId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT RequestId FROM FRIENDREQUESTS WHERE SenderId = @SenderId AND ReceiverId = @ReceiverId OR ReceiverId = @ReceiverId AND SenderId = @SenderId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SenderId", senderId);
                command.Parameters.AddWithValue("@ReceiverId", receiverId);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    requestId = (int)result;
                }
            }
            return requestId;
        }
    }
}