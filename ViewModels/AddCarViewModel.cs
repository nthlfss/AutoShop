using AutoShop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels
{
    public class AddCarViewModel
    {
        [Required]
        [Display(Name = "Make")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Error Error")]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Error Error")]
        [Display(Name = "Year")]
        public string Year { get; set; }

        public AddCarViewModel()
        {
        }
    }
}
