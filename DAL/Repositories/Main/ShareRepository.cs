using DAL.Models.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Main
{
    public class ShareRepository
    {
        private readonly string connectionString;

        public ShareRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }

        public void AddShare(int postId, int userId)
        {
            DateTime shareTime = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO SHARE (PostId, UserId, ShareTime) VALUES (@PostId, @UserId, @ShareTime)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PostId", postId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@ShareTime", shareTime);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteShare(int shareId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM SHARE WHERE ShareId = @ShareId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ShareId", shareId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateShare(int shareId, int postId, int userId)
        {
            DateTime shareTime = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE SHARE SET PostId = @PostId, UserId = @UserId, ShareTime = @ShareTime WHERE ShareId = @ShareId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ShareId", shareId);
                    command.Parameters.AddWithValue("@PostId", postId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@ShareTime", shareTime);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Share> GetAllShares()
        {
            List<Share> shares = new List<Share>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM SHARE";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Share share = new Share
                            {
                                ShareId = (int)reader["ShareId"],
                                PostId = (int)reader["PostId"],
                                UserId = (int)reader["UserId"],
                                ShareTime = (DateTime)reader["ShareTime"]
                            };
                            shares.Add(share);
                        }
                    }
                }
            }
            return shares;
        }
        public List<Share> GetSharesByUserId(int userId)
        {
            List<Share> shares = new List<Share>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM SHARE WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Share share = new Share
                            {
                                ShareId = (int)reader["ShareId"],
                                PostId = (int)reader["PostId"],
                                UserId = (int)reader["UserId"],
                                ShareTime = (DateTime)reader["ShareTime"]
                            };
                            shares.Add(share);
                        }
                    }
                }
            }
            return shares;
        }
    }
}