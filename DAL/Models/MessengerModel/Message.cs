using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public byte[] ContentImage { get; set; }
        public byte[] ContentIcon { get; set; }
        public byte[] ContentVideo { get; set; }
        public DateTime SentAt { get; set; }
    }
}
