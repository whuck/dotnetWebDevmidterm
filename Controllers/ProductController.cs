using System;
using Microsoft.AspNetCore.Mvc;
using Module5.Models;
using System.Linq;

namespace Module5.Controllers
{
    public class ProductController : Controller
    {
        
        //this controller depends on the bloggingRepository
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;

        //public IActionResult Index() => View(_bloggingContext.Blogs);
        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(b=>b.CategoryName));

        public IActionResult Index(int id) => View(_northwindContext.Products.Where(p=>p.CategoryId==id && !p.Discontinued));
        public IActionResult Discounts() => View(_northwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now));
    }
}