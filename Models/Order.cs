using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Order
    {
        [Key]
        public int Or_idx { get; set; }
        public int Cs_idx { get; set; }
        public int Sv_idx { get; set; }
        public double Total_Price { get; set; }
        public int Order_quentity { get; set; }
        public string Price_type { get; set; }
        public DateTime Order_date { get; set; }

        public Customer Customer;
        public Server Server;
    }
}
