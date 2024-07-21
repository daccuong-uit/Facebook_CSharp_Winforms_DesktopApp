using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Main
{
    public class Comments
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int UserCommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
