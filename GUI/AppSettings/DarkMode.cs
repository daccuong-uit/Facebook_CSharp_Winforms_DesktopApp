using System;

namespace GUI.AppSettings
{
    public class DarkMode
    {
        private static bool isDarkModeEnabled;

        public static bool IsDarkModeEnabled
        {
            get { return isDarkModeEnabled; }
            set
            {
                isDarkModeEnabled = value;
                OnDarkModeChanged?.Invoke(isDarkModeEnabled);
            }
        }

        public static event Action<bool> OnDarkModeChanged;
    }
}