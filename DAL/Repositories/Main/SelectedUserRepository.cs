using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Main
{
    public class SelectedUserRepository
    {
        private readonly string connectionString;

        public SelectedUserRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }

        public void InsertSelectedUser(int postId, int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO SELECTED_USERS (PostId, UserId) VALUES (@PostId, @UserId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PostId", postId);
                command.Parameters.AddWithValue("@UserId", userId);
                command.ExecuteNonQuery();
            }
        }
        public List<int> GetSelectedUsers(int postId)
        {
            List<int> selectedUsers = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId " +
                               "FROM SELECTED_USERS " +
                               "WHERE PostId = @PostId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PostId", postId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                        selectedUsers.Add(userId);
                    }
                }
            }

            return selectedUsers;
        }
        public void DeleteSelectedUsers(int postId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM SELECTED_USERS WHERE PostId = @PostId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PostId", postId);
                command.ExecuteNonQuery();
            }
        }
    }
}
