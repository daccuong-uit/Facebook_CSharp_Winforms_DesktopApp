using DAL.Models.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Main
{
    public class LikeLoveRepository
    {
        private readonly string connectionString;

        public LikeLoveRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }

        public void CreateLikeLove(int postId, int userLiketId, int content)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                INSERT INTO LIKELOVE (PostId, UserLiketId, Content)
                VALUES (@PostId, @UserLiketId, @Content)
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PostId", postId);
                    command.Parameters.AddWithValue("@UserLiketId", userLiketId);
                    command.Parameters.AddWithValue("@Content", content);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<LikeLove> GetLikeLoveByPostId(int postId)
        {
            List<LikeLove> likeLoves = new List<LikeLove>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT
                    l.LikeId,
                    l.PostId,
                    l.UserLiketId,
                    l.Content
                FROM LIKELOVE l
                WHERE l.PostId = @PostId
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PostId", postId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LikeLove likeLove = new LikeLove
                            {
                                LikeId = (int)reader["LikeId"],
                                PostId = (int)reader["PostId"],
                                UserLikeId = (int)reader["UserLiketId"],
                                Content = (int)reader["Content"]
                            };

                            likeLoves.Add(likeLove);
                        }
                    }
                }
            }

            return likeLoves;
        }

        public void UpdateLikeLove(int likeId, int newContent)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                UPDATE LIKELOVE
                SET Content = @NewContent
                WHERE LikeId = @LikeId
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewContent", newContent);
                    command.Parameters.AddWithValue("@LikeId", likeId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteLikeLove(int likeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                DELETE FROM LIKELOVE
                WHERE LikeId = @LikeId
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LikeId", likeId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public int GetLikeIdByUserLikeIdAndPostId(int userLikeId, int postId)
        {
            int likeId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT TOP 1 LikeId 
                FROM LIKELOVE
                WHERE UserLiketId = @UserLikeId AND PostId = @PostId
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserLikeId", userLikeId);
                    command.Parameters.AddWithValue("@PostId", postId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            likeId = (int)reader["LikeId"];
                        }
                    }
                }
            }

            return likeId;
        }
    }
}
