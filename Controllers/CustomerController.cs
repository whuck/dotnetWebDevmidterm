// You will add a controller method (Register) to the Customer controller
//  which will return a view when requested (/Customer/Register). 
//  The view will display a form designed to add customer data to the database.
using System;
using Microsoft.AspNetCore.Mvc;
using Module5.Models;
using System.Linq;

namespace Module5.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwindContext _northwindContext;
        public CustomerController(NorthwindContext db) => _northwindContext = db;

        [HttpPost]
        public IActionResult AddCustomer(string CompanyName) {
            Console.WriteLine(CompanyName);
            //return View();
            var c = new Customer();
            c.CompanyName=CompanyName;
            this._northwindContext.AddCustomer(c);
            return Content($"hi {CompanyName}");
        }
        public IActionResult Register() => View();

    }
}