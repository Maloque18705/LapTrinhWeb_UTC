using System.Diagnostics;
using KiemTra2.Models;
using Microsoft.AspNetCore.Mvc;

namespace KiemTra2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QlhangHoaContext _context;
        public HomeController(ILogger<HomeController> logger, QlhangHoaContext context)
        {
            _logger = logger;
            _context = context;

        }
        public IActionResult Index()
        {
            var sanPhams = _context.HangHoas
                                   .Where(p => p.Gia >= 100)
                                   .ToList();

            // Truy?n danh sách ?ã l?c sang View
            return View(sanPhams);
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

        public IActionResult FilterByLoai(int? maLoai)
        {
            var listHangHoa = _context.HangHoas.AsQueryable();
            if (maLoai.HasValue)
            {
                listHangHoa = listHangHoa.Where(h => h.MaLoai == maLoai.Value);
            }
            return PartialView("TranTienSon_DanhSachHangHoa", listHangHoa.ToList());
        }
    }
}
