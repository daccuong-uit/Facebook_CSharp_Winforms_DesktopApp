using DAL.Models.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Repositories.Main
{
    public class CommentsRepository
    {
        private readonly string connectionString;

        public CommentsRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }

        public void CreateComment(int postId, int userCommentId, string content)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                INSERT INTO COMMENTS (PostId, UserCommentId, Content, CreatedAt)
                VALUES (@PostId, @UserCommentId, @Content, @CreatedAt)
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PostId", postId);
                    command.Parameters.AddWithValue("@UserCommentId", userCommentId);
                    command.Parameters.AddWithValue("@Content", content);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Comments> GetCommentsByPostId(int postId, int offset = 0, int limit = 30)
        {
            List<Comments> comments = new List<Comments>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT
                    c.CommentId,
                    c.PostId,
                    c.UserCommentId,
                    c.Content,
                    c.CreatedAt
                FROM COMMENTS c
                WHERE c.PostId = @PostId
                ORDER BY c.CreatedAt DESC
                OFFSET @Offset ROWS
                FETCH NEXT @Limit ROWS ONLY
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PostId", postId);
                    command.Parameters.AddWithValue("@Offset", offset);
                    command.Parameters.AddWithValue("@Limit", limit);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comments comment = new Comments
                            {
                                CommentId = (int)reader["CommentId"],
                                PostId = (int)reader["PostId"],
                                UserCommentId = (int)reader["UserCommentId"],
                                Content = (string)reader["Content"],
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            };

                            comments.Add(comment);
                        }
                    }
                }
            }

            return comments;
        }

        public void UpdateComment(int commentId, string newContent)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                UPDATE COMMENTS
                SET Content = @NewContent
                WHERE CommentId = @CommentId
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewContent", newContent);
                    command.Parameters.AddWithValue("@CommentId", commentId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteComment(int commentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                DELETE FROM COMMENTS
                WHERE CommentId = @CommentId
            ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CommentId", commentId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public int GetMaxCommentId()
        {
            int maxCommentId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MAX(CommentId) FROM COMMENTS";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        maxCommentId = (int)result;
                    }
                }
            }

            return maxCommentId;
        }
    }
}
