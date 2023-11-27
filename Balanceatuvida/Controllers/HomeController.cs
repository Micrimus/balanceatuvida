using Balanceatuvida.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Balanceatuvida.Controllers
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
            var Title = new Title()
            {
                MainTitle = "Renace desde tu interior",
                Description = "Aprende a equilibrar tu rueda de la vida"
            };

            return View(Title);
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