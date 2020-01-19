using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Server
    {
        [Key]
        public int Sv_idx { get; set; }
        public string Sv_name { get; set; }
        public string Sv_type { get; set; }
        public string Sv_info { get; set; }
        public double Price { get; set; }

        public DateTime Enrollment_date { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
