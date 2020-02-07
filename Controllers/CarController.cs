using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoShop.Data;
using AutoShop.Models;
using AutoShop.ViewModels;

namespace AutoShop.Controllers
{
    public class CarController : Controller
    {
        private AutoDbContext context;

        public CarController(AutoDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            IList<Car> cars = context.Cars.ToList();
            return View(cars);
        }

        public IActionResult Add()
        {
            AddCarViewModel addCarViewModel = new AddCarViewModel();
            return View(addCarViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCarViewModel addCarViewModel)
        {
            if (ModelState.IsValid)
            {
                Car newCar = new Car
                {
                    Make = addCarViewModel.Make,
                    Model = addCarViewModel.Model,
                    Year = addCarViewModel.Year,
                };

                context.Cars.Add(newCar);
                context.SaveChanges();

                Response.Redirect("/Car?id=" + newCar.ID);
            }

            return View(addCarViewModel);
        }
    }
}