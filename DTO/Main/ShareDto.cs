using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Main
{
    public class ShareDto
    {
        public int ShareId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime ShareTime { get; set; }
    }
}
