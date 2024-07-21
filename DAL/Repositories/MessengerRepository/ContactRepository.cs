using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ContactRepository
    {
        private readonly string connectionString;

        public ContactRepository()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }

        //getContactsId(userId, contactUserId): Lấy contactId của 2 người
        public int GetContactId(int userId, int contactUserId)
        {
            int contactId;

            string contactQuery = "SELECT MIN(ContactId) FROM CONTACTS WHERE (UserId = @UserId AND ContactUserId = @ContactUserId) OR (UserId = @ContactUserId AND ContactUserId = @UserId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand contactCommand = new SqlCommand(contactQuery, connection))
                {
                    contactCommand.Parameters.AddWithValue("@UserId", userId);
                    contactCommand.Parameters.AddWithValue("@ContactUserId", contactUserId);

                    var result = contactCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        contactId = (int)result;
                    }
                    else
                    {
                        contactId = 1;
                    }
                }
            }

            return contactId;
        }

        //getContactsByUserId(userId): Lấy danh sách liên hệ của một người dùng dựa trên ID người dùng.
        public List<Contact> GetContactsByUserId(int userId)
        {
            List<Contact> contacts = new List<Contact>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Contacts WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Contact contact = new Contact
                        {
                            ContactId = Convert.ToInt32(reader["ContactId"]),
                            UserId = Convert.ToInt32(reader["UserId"]),
                            ContactUserId = Convert.ToInt32(reader["ContactUserId"])
                        };

                        contacts.Add(contact);
                    }
                }
            }
            return contacts;
        }
        // addContact(userId, contactUserId): Thêm một liên hệ mới vào danh bạ của người dùng.
        public void AddContact(int userId, int contactUserId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Thực hiện chèn vào danh bạ
                string insertQuery = @"
            INSERT INTO Contacts (UserId, ContactUserId)
            SELECT DISTINCT UserId, ContactUserId
            FROM (
                VALUES
                  (@UserId, @ContactUserId)
            ) AS TempTable(UserId, ContactUserId)
            WHERE NOT EXISTS (
                SELECT 1
                FROM Contacts
                WHERE UserId = TempTable.UserId AND ContactUserId = TempTable.ContactUserId
            )";

                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@UserId", userId);
                insertCommand.Parameters.AddWithValue("@ContactUserId", contactUserId);

                insertCommand.ExecuteNonQuery();
            }
        }
        //deleteContact(userId, contactId): Xóa một liên hệ khỏi danh bạ của người dùng dựa trên ID người dùng và ID liên hệ.
        /*public void DeleteContact(int userId, int contactId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Contacts WHERE UserId = @UserId AND ContactId = @ContactId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@ContactId", contactId);

                command.ExecuteNonQuery();
            }
        }*/
    }
}
