using Microsoft.AspNetCore.Mvc;

namespace Trewike.Areas.WorkArea.Controllers
{
    [Area("WorkArea")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
