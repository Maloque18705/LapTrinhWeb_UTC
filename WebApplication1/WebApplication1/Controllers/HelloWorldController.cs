using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome method...";
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sample()
        {
            return View();
        }
    }
}
