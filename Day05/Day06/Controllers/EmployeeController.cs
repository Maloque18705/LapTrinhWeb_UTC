using Day05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day05.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employee()
        {
            var objEmployee = new Employee
            {
                Id = 1001,
                FullName = "Nguyen Van A",
                Gender = "Male",
                Phone = "0901234567",
                Email = "vana@example.com",
                Salary = 1500,
                Status = true
            };
            ViewBag.user = objEmployee;
            return View();
        }

        public IActionResult ListEmployee()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FullName = "Nguyen Van A", Gender = "Male",   Phone = "0901111111", Email = "vana@example.com", Salary = 1500, Status = true },
                new Employee { Id = 2, FullName = "Tran Thi B",   Gender = "Female", Phone = "0902222222", Email = "thib@example.com", Salary = 2000, Status = true },
                new Employee { Id = 3, FullName = "Le Van C",     Gender = "Male",   Phone = "0903333333", Email = "levc@example.com", Salary = 1800, Status = false },
                new Employee { Id = 4, FullName = "Pham Thi D",   Gender = "Female", Phone = "0904444444", Email = "thid@example.com", Salary = 2200, Status = true },
                new Employee { Id = 5, FullName = "Do Van E",     Gender = "Male",   Phone = "0905555555", Email = "dove@example.com", Salary = 1700, Status = true }
            };

            return View(employees);
        }
    }
}
