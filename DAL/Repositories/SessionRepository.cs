using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class SessionRepository
    {
        private readonly string connectionString;

        public SessionRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }
        public int CreateSession(int userId, bool isLoggedIn)
        {
            int isLoggedInInt;
            if (isLoggedIn == true)
            {
                isLoggedInInt = 1;
            }
            else
            {
                isLoggedInInt = 0;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Kiểm tra xem đã có session cho người dùng này chưa
                string checkQuery = "SELECT SessionId FROM SESSION WHERE UserId = @UserId AND IsLoggedIn = @IsLoggedIn";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@UserId", userId);
                checkCommand.Parameters.AddWithValue("@IsLoggedIn", isLoggedInInt);

                connection.Open();
                object result = checkCommand.ExecuteScalar();
                if (result != null)
                {
                    // Đã có session, trả về SessionId
                    return Convert.ToInt32(result);
                }

                // Chưa có session, tạo mới
                string createQuery = "INSERT INTO SESSION (IsLoggedIn, UserId) VALUES (@IsLoggedIn, @UserId); SELECT SCOPE_IDENTITY();";
                SqlCommand createCommand = new SqlCommand(createQuery, connection);
                createCommand.Parameters.AddWithValue("@IsLoggedIn", isLoggedInInt);
                createCommand.Parameters.AddWithValue("@UserId", userId);

                int sessionId = Convert.ToInt32(createCommand.ExecuteScalar());
                return sessionId;
            }
        }

        public void UpdateSession(int sessionId, bool isLoggedIn)
        {
            int isLoggedInInt;
            if (isLoggedIn == true)
            {
                isLoggedInInt = 1;
            }
            else
            {
                isLoggedInInt = 0;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE SESSION SET IsLoggedIn = @IsLoggedIn WHERE SessionId = @SessionId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IsLoggedIn", isLoggedInInt);
                command.Parameters.AddWithValue("@SessionId", sessionId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Session GetSession(int sessionId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SessionId, IsLoggedIn, UserId FROM SESSION WHERE SessionId = @SessionId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SessionId", sessionId);

                    connection.Open();

                    Session session = null;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            session = new Session
                            {
                                SessionId = (int)reader["SessionId"],
                                UserId = (int)reader["UserId"],
                                IsLoggedIn = (int)reader["IsLoggedIn"]
                            };
                        }
                    }

                    return session;
                }
            }
        }
        public int GetSessionId(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 SessionId FROM SESSION WHERE UserId = @UserId ORDER BY SessionId DESC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}