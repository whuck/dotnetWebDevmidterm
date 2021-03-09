using System;
using Microsoft.AspNetCore.Mvc;
using Module5.Models;
using System.Linq;

namespace Module5.Controllers
{
    public class HomeController : Controller
    {
//        public IActionResult Index() => View();
        private NorthwindContext _northwindContext;
        public HomeController(NorthwindContext db) => _northwindContext = db;
        //public IActionResult Index() => View(_northwindContext.Discounts);
        public IActionResult Index() => View(_northwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));
    }
}