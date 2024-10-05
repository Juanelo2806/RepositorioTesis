using Microsoft.AspNetCore.Mvc;
using PruebasGitHub.Models;
using System.Diagnostics;

namespace PruebasGitHub.Controllers
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

        public IActionResult saludar(string mensaje)
        {
            mensaje = "hola mundo";
            return View("Saludar", mensaje);
        }
    }
}
