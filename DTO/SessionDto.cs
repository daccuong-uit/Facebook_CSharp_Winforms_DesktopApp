using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SessionDto
    {
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public int IsLoggedIn { get; set; }
    }
}
