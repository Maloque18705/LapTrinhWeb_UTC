using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QLBongDa.Models;

namespace QLBongDa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QlgiaiBongDaContext _context;

        public HomeController(ILogger<HomeController> logger, QlgiaiBongDaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var cauthus = _context.Cauthus.ToList();
            return View(cauthus);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult FilterByCLB(int? CauLacBoID)
        {
            var listCauThu  = _context.Cauthus.AsQueryable();
            if (CauLacBoID.HasValue)
            {
                listCauThu = listCauThu.Where(ct => ct.CauLacBoId == CauLacBoID.ToString());
            }
            return PartialView("TranTienSon_DanhSachCauThu", listCauThu.ToList());
        }
    }
}
