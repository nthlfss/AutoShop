using AutoShop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels
{
    public class AddCustomerViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Error Error")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Error Error")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Error Error")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        public AddCustomerViewModel()
        {
        }

    }
}
