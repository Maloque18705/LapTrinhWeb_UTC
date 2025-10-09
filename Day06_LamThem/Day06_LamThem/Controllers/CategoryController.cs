using Microsoft.AspNetCore.Mvc;

namespace Day06_LamThem.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
