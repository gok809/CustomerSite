using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Customer
    {
        [Key]
        public int Cs_idx { get; set; }
        public string Id { get; set; }
        public string Pw { get; set; }
        public DateTime Join_date { get; set; }
        public DateTime Login_date { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
