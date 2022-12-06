using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using vssecurityapp.Models;

namespace vssecurityapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("Login")]
        public IActionResult Login()
        {
            return View("~/Views/Login.cshtml");
        }

        [Route("Cadastro")]
        public IActionResult Cadastro()
        {
            return View("~/Views/Cadastro.cshtml");
        }

        [Route("Duvida")]
        public IActionResult Duvida()
        {
            return View("~/Views/Duvida.cshtml");
        }

        [Route("Cotacao")]
        public IActionResult Cotacao()
        {
            return View("~/Views/Cotacao.cshtml");
        }

        [Route("Home")]
        public IActionResult Home()
        {
            return View("~/Views/Shared/_Layout.cshtml");
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
    }
}