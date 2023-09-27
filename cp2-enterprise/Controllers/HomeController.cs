using cp2_enterprise.Models;
using cp2_enterprise.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cp2_enterprise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OracleContext _oracleContext;

        public HomeController(ILogger<HomeController> logger, OracleContext oracleContext)
        {
            _logger = logger;
            _oracleContext = oracleContext;
        }

        public IActionResult Index()
        {
            ViewData["coments"] = _oracleContext.Comentarios
                .Where(coment => coment.AutorizaNome && coment.Estrelas >= 4)
                .Take(5);

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