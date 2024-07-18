using ab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ab.Controllers
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
            var s = new List<Student>{

            new Student { Id = 12, Name = "Aqib", Age =18, standard="10" },

            new Student { Id = 12, Name = "Taha", Age =18, standard="10" },

            new Student { Id = 12, Name = "Bilal", Age =18, standard="10" },

            new Student { Id = 12, Name = "Umair", Age =18, standard="10" },

            };
            TempData["model_data"] = s;
            return View();
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
