using KiemTra2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KiemTra2.Controllers
{
    public class ProductController : Controller
    {
        private readonly QlhangHoaContext _context;
    
        public ProductController(QlhangHoaContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(_context.LoaiHangs, "MaLoai", "TenLoai");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HangHoa model)
        {
            ModelState.Remove("MaHang");
            ModelState.Remove("MaLoaiNavigation");
            if (ModelState.IsValid)
            {
                _context.HangHoas.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.MaLoai = new SelectList(_context.LoaiHangs, "MaLoai", "TenLoai", model.MaLoai);
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
