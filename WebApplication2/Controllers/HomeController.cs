using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Product 1", Price = 10, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Product 2", Price = 19, CreatedDate = DateTime.Now },
                new Product { ID = 3, Name = "Product 3", Price = 5, CreatedDate = DateTime.Now }
            };


            Console.WriteLine(products);


            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}