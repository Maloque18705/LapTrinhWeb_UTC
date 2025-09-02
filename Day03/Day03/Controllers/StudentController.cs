using Day03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day03.Controllers
{
    public class StudentController : Controller
    {

        private static List<StudentModel> students = new List<StudentModel>
        {
            new StudentModel { Id = 1, Name = "Nguyen Van A", Class = "K65", Gender = "Male", Age = 22, IsActive = true },
            new StudentModel { Id = 2, Name = "Tran Thi B", Class = "K66", Gender = "Female", Age = 21, IsActive = true },
            new StudentModel { Id = 3, Name = "Le Van C", Class = "K65", Gender = "Male", Age = 22, IsActive = false }
        };
          
       
        public IActionResult Index()
        {
            return View(students);
        }


    }
}
