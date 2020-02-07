using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(4)]
        public string Year { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Make { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public List<Repair> Repairs { get; set; } = new List<Repair>();
    }
}
