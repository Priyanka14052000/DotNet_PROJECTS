using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tickets()
        {
            return View();
        }
        public IActionResult Payments()
        {
            return View();
        }
    }
}
