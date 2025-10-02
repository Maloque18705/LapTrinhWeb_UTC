using Microsoft.AspNetCore.Mvc;
using HandOn_Day6.Models;
namespace HandOn_Day6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserManual()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserManudotnetal(User user)
        {
            string password = user.Password;
            if (password.Length < 7)
            {
                ViewBag.PasswordErr = "Password must be at least 7 characters long.";
                return View();
            }

            string email = user.Email;
            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, regexPattern))
            {
                return Content("You have successfully registered");
            }
            else
            {
                return View();
            }
        }
    }
}
