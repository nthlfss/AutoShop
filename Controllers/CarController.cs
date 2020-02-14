using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoShop.Data;
using AutoShop.Models;
using AutoShop.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AutoShop.Controllers
{
    public class CarController : Controller
    {
        private readonly AutoDbContext context;

        public CarController(AutoDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            IList<Car> cars = context.Cars.Include(c => c.Customer).ToList();
            return View(cars);
        }

        public IActionResult Add()
        {
            AddCarViewModel addCarViewModel = new AddCarViewModel(context.Customers.ToList());
            return View(addCarViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCarViewModel addCarViewModel)
        {
            if (ModelState.IsValid)
            {
                Customer newCustomer =
                        context.Customers.Single(c => c.ID == addCarViewModel.CustomerID);


                Car newCar = new Car
                {
                    Make = addCarViewModel.Make,
                    Model = addCarViewModel.Model,
                    Year = addCarViewModel.Year,
                    CustomerID = addCarViewModel.CustomerID
                };

                context.Cars.Add(newCar);
                context.SaveChanges();

                Response.Redirect("/Car?id=" + newCar.ID);
            }

            return View(addCarViewModel);
        }
    }
}