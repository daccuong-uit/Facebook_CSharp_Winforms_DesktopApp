using DAL.Models.Main;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Main
{
    public class PostingRepository
    {
        private readonly string connectionString;

        public PostingRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }
        public void Posting(int userId, string caption, int option, string media, int statitude, int share)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO POSTS (
                Caption,
                OptionId,
                Media,
                Statitude,
                Share,
                CreatedAt,
                UserId
            )
            VALUES (
                @Caption,
                @OptionId,
                @Media,
                @Statitude,
                @Share,
                @CreatedAt,
                @UserId
            )
        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (string.IsNullOrEmpty(caption))
                    {
                        command.Parameters.AddWithValue("@Caption", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Caption", caption);
                    }
                    command.Parameters.AddWithValue("@OptionId", option);

                    if (string.IsNullOrEmpty(media))
                    {
                        command.Parameters.AddWithValue("@Media", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Media", media);
                    }

                    command.Parameters.AddWithValue("@Statitude", statitude);
                    command.Parameters.AddWithValue("@Share", share);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    command.Parameters.AddWithValue("@UserId", userId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Posting> GetPosts(int userId, int offset = 0, int limit = 30)
        {
            List<Posting> posts = new List<Posting>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT
                p.PostId,
                p.Caption,
                p.OptionId,
                p.Media,
                p.Statitude,
                p.Share,
                p.CreatedAt,
                p.UserId
            FROM POSTS p
            WHERE p.UserId = @UserId
            ORDER BY p.CreatedAt DESC
            OFFSET @Offset ROWS
            FETCH NEXT @Limit ROWS ONLY
        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Offset", offset);
                    command.Parameters.AddWithValue("@Limit", limit);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Posting post = new Posting
                            {
                                PostId = (int)reader["PostId"],
                                Caption = (string)reader["Caption"],
                                OptionId = (int)reader["OptionId"],
                                Media = reader["Media"] as string,
                                Statitude = (int)reader["Statitude"],
                                Share = (int)reader["Share"],
                                CreatedAt = (DateTime)reader["CreatedAt"],
                                UserPostId = (int)reader["UserId"]
                            };

                            posts.Add(post);
                        }
                    }
                }
            }

            return posts;
        }
        public List<Posting> GetAllPosts(int offset, int limit)
        {
            List<Posting> posts = new List<Posting>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT
                p.PostId,
                p.Caption,
                p.OptionId,
                p.Media,
                p.Statitude,
                p.Share,
                p.CreatedAt,
                p.UserId
            FROM POSTS p
            ORDER BY p.CreatedAt DESC
            OFFSET @Offset ROWS
            FETCH NEXT @Limit ROWS ONLY
        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Offset", offset);
                    command.Parameters.AddWithValue("@Limit", limit);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Posting post = new Posting
                            {
                                PostId = (int)reader["PostId"],
                                Caption = reader["Caption"] as string,
                                OptionId = (int)reader["OptionId"],
                                Media = reader["Media"] as string,
                                Statitude = (int)reader["Statitude"],
                                Share = (int)reader["Share"],
                                CreatedAt = (DateTime)reader["CreatedAt"],
                                UserPostId = (int)reader["UserId"]
                            };

                            posts.Add(post);
                        }
                    }
                }
            }

            return posts;
        }
        public int GetMaxPostId()
        {
            int maxPostId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MAX(PostId) FROM POSTS";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxPostId = Convert.ToInt32(result);
                    }
                }
            }

            return maxPostId;
        }
        public Posting GetPostByPostId(int postId)
        {
            Posting post = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT
                p.PostId,
                p.Caption,
                p.OptionId,
                p.Media,
                p.Statitude,
                p.Share,
                p.CreatedAt,
                p.UserId
            FROM POSTS p
            WHERE p.PostId = @PostId
        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PostId", postId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            post = new Posting
                            {
                                PostId = (int)reader["PostId"],
                                Caption = reader["Caption"] as string,
                                OptionId = (int)reader["OptionId"],
                                Media = reader["Media"] as string,
                                Statitude = (int)reader["Statitude"],
                                Share = (int)reader["Share"],
                                CreatedAt = (DateTime)reader["CreatedAt"],
                                UserPostId = (int)reader["UserId"]
                            };
                        }
                    }
                }
            }

            return post;
        }
        public void UpdateOption(int postId, int newOption)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            UPDATE POSTS
            SET OptionId = @NewOption
            WHERE PostId = @PostId
        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewOption", newOption);
                    command.Parameters.AddWithValue("@PostId", postId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
