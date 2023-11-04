using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trewike.Models;

namespace Trewike.Controllers
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

        public IActionResult CheckSession()
        {
            return Redirect("/loginarea/login/index");
        }
    }
}