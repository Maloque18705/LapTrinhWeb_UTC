using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using QLBanSach.Models;

namespace QLBanSach.Controllers
{
    public class SachController : Controller
    {
        private readonly QlbanSachContext _context;

        public SachController(QlbanSachContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listSach = _context.TSaches.ToList();
            return View(listSach);
        }
        public IActionResult Create()
        {
            ViewBag.MaTheLoai = new SelectList(_context.TTheLoais, "MaTheLoai", "TenTheLoai");
            return View();           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TSach model)
        {
            if (ModelState.IsValid)
            {
                _context.TSaches.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.MaTheLoai = new SelectList(_context.TTheLoais, "MaTheLoai", "TenTheLoai", model.MaTheLoai);
            return View(model);
        }
        
    }
}
