using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLBongDa.Models;

namespace QLBongDa.Controllers
{
    public class CaulacboesController : Controller
    {
        private readonly QlgiaiBongDaContext _context;

        public CaulacboesController(QlgiaiBongDaContext context)
        {
            _context = context;
        }

        // GET: Caulacboes
        public async Task<IActionResult> Index()
        {
            var qlgiaiBongDaContext = _context.Caulacbos.Include(c => c.HuanLuyenVien).Include(c => c.SanVanDong);
            return View(await qlgiaiBongDaContext.ToListAsync());
        }

        // GET: Caulacboes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caulacbo = await _context.Caulacbos
                .Include(c => c.HuanLuyenVien)
                .Include(c => c.SanVanDong)
                .FirstOrDefaultAsync(m => m.CauLacBoId == id);
            if (caulacbo == null)
            {
                return NotFound();
            }

            return View(caulacbo);
        }

        // GET: Caulacboes/Create
        public IActionResult Create()
        {
            ViewData["HuanLuyenVienId"] = new SelectList(_context.Huanluyenviens, "HuanLuyenVienId", "HuanLuyenVienId");
            ViewData["SanVanDongId"] = new SelectList(_context.Sanvandongs, "SanVanDongId", "SanVanDongId");
            return View();
        }

        // POST: Caulacboes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CauLacBoId,TenClb,TenGoi,SanVanDongId,HuanLuyenVienId,Anh,SoTranDau")] Caulacbo caulacbo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caulacbo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HuanLuyenVienId"] = new SelectList(_context.Huanluyenviens, "HuanLuyenVienId", "HuanLuyenVienId", caulacbo.HuanLuyenVienId);
            ViewData["SanVanDongId"] = new SelectList(_context.Sanvandongs, "SanVanDongId", "SanVanDongId", caulacbo.SanVanDongId);
            return View(caulacbo);
        }

        // GET: Caulacboes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caulacbo = await _context.Caulacbos.FindAsync(id);
            if (caulacbo == null)
            {
                return NotFound();
            }
            ViewData["HuanLuyenVienId"] = new SelectList(_context.Huanluyenviens, "HuanLuyenVienId", "HuanLuyenVienId", caulacbo.HuanLuyenVienId);
            ViewData["SanVanDongId"] = new SelectList(_context.Sanvandongs, "SanVanDongId", "SanVanDongId", caulacbo.SanVanDongId);
            return View(caulacbo);
        }

        // POST: Caulacboes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CauLacBoId,TenClb,TenGoi,SanVanDongId,HuanLuyenVienId,Anh,SoTranDau")] Caulacbo caulacbo)
        {
            if (id != caulacbo.CauLacBoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caulacbo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaulacboExists(caulacbo.CauLacBoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["HuanLuyenVienId"] = new SelectList(_context.Huanluyenviens, "HuanLuyenVienId", "HuanLuyenVienId", caulacbo.HuanLuyenVienId);
            ViewData["SanVanDongId"] = new SelectList(_context.Sanvandongs, "SanVanDongId", "SanVanDongId", caulacbo.SanVanDongId);
            return View(caulacbo);
        }

        // GET: Caulacboes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caulacbo = await _context.Caulacbos
                .Include(c => c.HuanLuyenVien)
                .Include(c => c.SanVanDong)
                .FirstOrDefaultAsync(m => m.CauLacBoId == id);
            if (caulacbo == null)
            {
                return NotFound();
            }

            return View(caulacbo);
        }

        // POST: Caulacboes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var caulacbo = await _context.Caulacbos.FindAsync(id);
            if (caulacbo != null)
            {
                _context.Caulacbos.Remove(caulacbo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaulacboExists(string id)
        {
            return _context.Caulacbos.Any(e => e.CauLacBoId == id);
        }
    }
}
