using Microsoft.AspNetCore.Mvc;
using Module5.Models;

namespace Blogs.Controllers
{
    public class HomeController : Controller
    {
//        public IActionResult Index() => View();
        private NorthwindContext _northwindContext;
        public HomeController(NorthwindContext db) => _northwindContext = db;
        public IActionResult Index() => View(_northwindContext.Products);
    }
}