using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ChatRepository
    {
        private readonly string connectionString;

        public ChatRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }

        // Thêm một người tham gia vào cuộc trò chuyện.
        public void AddParticipant(int chatId, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO ChatParticipants (ChatId, UserId) VALUES (@ChatId, @UserId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ChatId", chatId);
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }

        // Xóa một người tham gia khỏi cuộc trò chuyện.
        public void RemoveParticipant(int chatId, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM ChatParticipants WHERE ChatId = @ChatId AND UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ChatId", chatId);
                command.Parameters.AddWithValue("@UserId", userId);

                command.ExecuteNonQuery();
            }
        }

        // Lấy danh sách người tham gia của một cuộc trò chuyện dựa trên ID cuộc trò chuyện.
        private List<int> GetParticipantsByChatId(int chatId)
        {
            List<int> participants = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT UserId FROM ChatParticipants WHERE ChatId = @ChatId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ChatId", chatId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["UserId"]);
                        participants.Add(userId);
                    }
                }
            }

            return participants;
        }
    }
}
