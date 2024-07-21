using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SettingDto
    {
        public int SettingId { get; set; }
        public int UserId { get; set; }
        public bool NotificationEnabled { get; set; }
        public string Language { get; set; }
        public bool DarkMode { get; set; }
    }
}
