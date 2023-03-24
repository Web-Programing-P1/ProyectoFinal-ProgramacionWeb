using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Models;
using System.Diagnostics;

namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DealerContext _dealerContext;

        public HomeController(ILogger<HomeController> logger, DealerContext dealerContext)
        {
            _logger = logger;
            _dealerContext = dealerContext;
        }

        public IActionResult Index()
        {
            var Modelos = _dealerContext.Modelos.ToList(); 
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