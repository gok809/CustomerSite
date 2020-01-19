using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Admin
    {
        [Key]
        public int Ad_idx { get; set; }
        public string Ad_id { get; set; }
        public string Ad_pw { get; set; }
        public int Ad_level { get; set; }
        public int Login_count { get; set; }
        public DateTime Ad_login_date { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}