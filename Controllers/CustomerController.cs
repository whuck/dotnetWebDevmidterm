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
        public IActionResult AddCustomer(Customer c) {
            if(ModelState.IsValid){
                //check for dupes
                var hasDupes = this._northwindContext.Customers.Any(p => p.CompanyName == c.CompanyName);
                if(hasDupes) {
                    return View("Register");
                } else {
                    this._northwindContext.AddCustomer(c);
                    return Redirect("/Home/Index");
                }
                
            } else {
                //not valid form
                return View("Register");
            }
        }
        public IActionResult Register() => View();

    }
}