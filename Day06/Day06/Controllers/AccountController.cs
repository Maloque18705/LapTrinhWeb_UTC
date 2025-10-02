using Microsoft.AspNetCore.Mvc;
using Day06.Models;
using System.Text.RegularExpressions;
namespace Day06.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public IActionResult Index ()
        {
            List<Account> accounts = new List<Account>();
            return View(accounts);
        }
        // GET: Account/Create
        public IActionResult Create ()
        {
            Account model = new Account();
            return View(model);
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone (string phone)
        {
            Regex _isPhone = new Regex(@"^\(?[0-9]{3}\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (!_isPhone.IsMatch(phone))
            {
                return Json($"Số điện thoại {phone} không đúng định dạng.");
            }
            return Json(true);
        }
    }
}
