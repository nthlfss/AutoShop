using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class Repair
    {
        public int ID { get; set; }
        public string Date { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Comments { get; set; }

        [Required]
        public int Hours { get; set; }

        [Required]
        public int Cost { get; set; }
    }
}
