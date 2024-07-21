using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using DAL.Models;

namespace DAL.Repositories
{
    public class UserRepository
    {
        private readonly string connectionString;

        public UserRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }
        //Login
        public User GetUserByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM USERS WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = (int)reader["UserId"],
                                Username = (string)reader["Username"],
                                Password = (string)reader["Password"]
                            };
                            return user;
                        }
                    }
                }
            }

            return null;
        }
        //Register user
        public void Register(User user)
        {
            if (IsUserExists(user.Email))
            {
                throw new Exception("Người dùng đã tồn tại.");
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO USERS (Name, LastName, Username, Email, PhoneNumber, Password, Avatar) " +
                               "VALUES (@Name, @LastName, @Username, @Email, @PhoneNumber,@Password, @Avatar)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Avatar", user.Avatar);
                    command.ExecuteNonQuery();
                }
            }
        }
        //Delete User
        /*public bool DeleteUser(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM USERS WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }*/
        //Check isUserExists
        public bool IsUserExists(string email)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM USERS WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    exists = (count > 0);
                }
            }

            return exists;
        }
        //Update Password
        public bool ResetPassword(string email, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE USERS SET Password = @NewPassword WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        //Update Avatar
        public bool UpdateAvatar(int userId, string newAvatar)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE USERS SET Avatar = @NewAvatar WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewAvatar", newAvatar);
                    command.Parameters.AddWithValue("@UserId", userId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        // Get userByUserId
        public User GetUserByUserId(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM USERS WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User
                            {
                                UserId = (int)reader["UserId"],
                                Name = (string)reader["Name"],
                                LastName = (string)reader["LastName"],
                                Username = (string)reader["Username"],
                                Email = (string)reader["Email"],
                                PhoneNumber = (string)reader["PhoneNumber"],
                                Password = (string)reader["Password"],
                                Avatar = (string)reader["Avatar"]
                            };
                            return user;
                        }
                    }
                }
            }
            return null;
        }
        // GET all user id
        public int GetNumberOfUser()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(UserId) FROM USERS";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }
        }

        // GET userId by email
        public int GetUserIdByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId FROM USERS WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int userId = (int)command.ExecuteScalar();
                    return userId;
                }
            }
        }

        //Get all userId
        public List<int> GetAllUserIds()
        {
            List<int> userIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserId FROM USERS";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("UserId"));
                            userIds.Add(userId);
                        }
                    }
                }
            }

            return userIds;
        }
    }
}