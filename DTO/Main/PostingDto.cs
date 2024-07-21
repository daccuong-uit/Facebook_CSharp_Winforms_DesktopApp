using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Main
{
    public class PostingDto
    {
        public int PostId { get; set; }
        public int UserPostId { get; set; }
        public string Caption { get; set; }
        public int OptionId { get; set; }
        public string Media { get; set; }
        public int Statitude { get; set; }
        public int Share { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
