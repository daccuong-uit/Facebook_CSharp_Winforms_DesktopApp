using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Main
{
    public class LikeLoveDto
    {
        public int LikeId { get; set; }
        public int PostId { get; set; }
        public int UserLikeId { get; set; }
        public int Content { get; set; }
    }
}
