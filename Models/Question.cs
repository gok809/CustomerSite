using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Question
    {
        [Key]
        public int Qs_idx { get; set; }
        public int Cs_idx { get; set; }
        public int Ad_idx { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Quest_date { get; set; }
        public Customer Customer { get; set; }
        public Admin Admin { get; set; }
    }
}
