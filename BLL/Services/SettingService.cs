using DAL.Repositories;
using System;

namespace BLL.Services
{
    public class SettingService
    {
        private readonly SettingRepositories settingRepositories;

        public SettingService()
        {
            settingRepositories = new SettingRepositories();
        }

        // Thêm một người tham gia vào cuộc trò chuyện.
        public void AddSetting(int userId)
        {
            settingRepositories.AddSetting(userId, false, "Vietnam", false);
        }

        // Update setting
        public void UpdateSetting(int userId, bool notificationEnabled, string language, bool darkMode)
        {
            settingRepositories.UpdateSetting(userId, notificationEnabled, language, darkMode);
        }

        // GET setting
        public void GetSettingByUserId(int userId)
        {
            settingRepositories.GetSettingByUserId(userId);
        }
    }
}