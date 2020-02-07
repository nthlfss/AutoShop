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
    public class CustomerController : Controller
    {
        private AutoDbContext context;

        public CustomerController(AutoDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index(int id)
        {
            Customer aCustomer = context.Customers.Find(id);
            return View(aCustomer);
        }

        public IActionResult Add()
        {
            AddCustomerViewModel addCustomerViewModel = new AddCustomerViewModel();
            return View(addCustomerViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCustomerViewModel addCustomerViewModel)
        {
            if (ModelState.IsValid)
            {
                Customer newCustomer = new Customer
                {
                    FirstName = addCustomerViewModel.FirstName,
                    LastName = addCustomerViewModel.LastName,
                    Email = addCustomerViewModel.Email,
                    Phone = addCustomerViewModel.Phone,
                };

                context.Customers.Add(newCustomer);
                context.SaveChanges();

                Response.Redirect("/Customer?id=" + newCustomer.ID);
            }

            return View(addCustomerViewModel);
        }
    }
}