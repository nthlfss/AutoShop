using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class ShopManager
    {
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPass { get; set; }

        public List<Customer> Customers { get; set; } = new List<Customer>();

    }
}
