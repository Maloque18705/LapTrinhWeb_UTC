using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QLBanSach.Models;

namespace QLBanSach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QlbanSachContext _context;

        public HomeController(ILogger<HomeController> logger, QlbanSachContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listSach  = _context.TSaches.ToList();
            var listTheLoai = _context.TTheLoais.ToList();
            return View(listSach);
        }

        public IActionResult FilterByTheLoai(string? maTheLoai, int? page)
        {
            var listSach = _context.TSaches.AsQueryable();

            //PAGINATION


            if (!string.IsNullOrEmpty(maTheLoai))
            {
                listSach = listSach.Where(s => s.MaTheLoai == maTheLoai);
            }

            int pageSize = 2;
            int pageNumber = page ?? 1;
            
            int totalItmes = listSach.Count();
            int totalPages = (int)Math.Ceiling((double)totalItmes / pageSize);

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = pageNumber;
            ViewBag.CurrentTheLoai = maTheLoai;

            var pagedData = listSach.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return PartialView("TranTienSon_DanhSachSach", pagedData);
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
    }
}
