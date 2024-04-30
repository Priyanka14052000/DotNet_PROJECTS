using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
