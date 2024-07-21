using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SettingRepositories
    {
        private readonly string connectionString;

        public SettingRepositories()
        {
            connectionString = "Data Source=NGUYEN-DAC-CUON\\SQLEXPRESS;Initial Catalog=FACEBOOK;Integrated Security=True";
        }
        // Thêm một setting 
        public void AddSetting(int userId, bool notificationEnabled, string language, bool darkMode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SETTINGS (UserId, NotificationEnabled, Language, DarkMode) " +
                               "VALUES (@UserId, @NotificationEnabled, @Language, @DarkMode)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@NotificationEnabled", notificationEnabled);
                command.Parameters.AddWithValue("@Language", language);
                command.Parameters.AddWithValue("@DarkMode", darkMode);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        // Hàm update Setting
        public void UpdateSetting(int userId, bool notificationEnabled, string language, bool darkMode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE SETTINGS " +
                               "SET NotificationEnabled = @NotificationEnabled, Language = @Language, DarkMode = @DarkMode " +
                               "WHERE UserId = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@NotificationEnabled", notificationEnabled);
                command.Parameters.AddWithValue("@Language", language);
                command.Parameters.AddWithValue("@DarkMode", darkMode);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        //Get setting
        public Setting GetSettingByUserId(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SETTINGS WHERE UserId = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Setting setting = new Setting();
                    setting.SettingId = (int)reader["SettingId"];
                    setting.UserId = (int)reader["UserId"];
                    setting.NotificationEnabled = (bool)reader["NotificationEnabled"];
                    setting.Language = reader["Language"].ToString();
                    setting.DarkMode = (bool)reader["DarkMode"];

                    reader.Close();
                    return setting;
                }
            }

            return null;
        }

    }
}