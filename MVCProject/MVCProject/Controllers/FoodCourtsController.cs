using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class FoodCourtsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
