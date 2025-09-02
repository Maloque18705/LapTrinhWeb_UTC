using Day03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Day03.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult Index()
        {
            var student = new StudentModel
            {
                Id = 100,
                Name = "Data Passer",
                Class = "MVC-Demo",
                Gender = "N/A",
                Age = 20,
                IsActive = true
            };

            ViewBag.StudentVB = student;
            ViewBag.Greeting = "Xin chào từ ViewBag!";

            return View();
        }

        public IActionResult ViewDataDemo()
        {
            ViewData["name"] = "Son";
            ViewData["time"] = DateTime.Now;

            // Object

            // List Object
            List<StudentModel> students = new List<StudentModel>
            {
                new StudentModel {Id = 1, Name = "Nguyễn Văn A", Age=20, Gender="Male", IsActive=true },
                new StudentModel {Id = 2, Name = "Nguyễn Văn B", Age=18, Gender="Female", IsActive=false},
                new StudentModel {Id = 3, Name = "Lê Văn C", Age=21, Gender="Male", IsActive=true}
            };

            return View();
        }
    }
}
