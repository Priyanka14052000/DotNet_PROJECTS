using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
