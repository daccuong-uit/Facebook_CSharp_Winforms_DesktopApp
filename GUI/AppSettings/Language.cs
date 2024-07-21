using System;

namespace GUI.AppSettings
{
    public class Language
    {
        private static bool isEnglishEnabled;

        public static bool IsEnglishEnabled
        {
            get { return isEnglishEnabled; }
            set
            {
                isEnglishEnabled = value;
                OnEnglishChanged?.Invoke(isEnglishEnabled);
            }
        }

        public static event Action<bool> OnEnglishChanged;
    }
}