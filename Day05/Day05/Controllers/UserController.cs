using AspNetCoreGeneratedDocument;
using Day05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day05.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult user()
        {
            var objUser = new User();
            objUser.Id = 101;
            objUser.Name = "Hai Duc";
            objUser.Address = "Kim Dong";
            objUser.Email = "haiduc@gmail.com";

            ViewBag.user = objUser;

            return View();
        }

    public IActionResult ListUser()
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Name = "Nguyen Van A", Address = "Ha Noi", Email = "vana@example.com" },
            new User { Id = 2, Name = "Tran Thi B", Address = "Da Nang", Email = "thib@example.com" },
            new User { Id = 3, Name = "Le Van C", Address = "Hai Phong", Email = "levc@example.com" },
            new User { Id = 4, Name = "Pham Thi D", Address = "Ho Chi Minh", Email = "thid@example.com" },
            new User { Id = 5, Name = "Do Van E", Address = "Can Tho", Email = "dove@example.com" }
            };
            return View(users);
        }
    }

}
