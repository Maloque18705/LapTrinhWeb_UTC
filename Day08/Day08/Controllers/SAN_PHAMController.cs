using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Day08.Entities;
using Day08.Models;

namespace Day08.Controllers
{
    public class SAN_PHAMController : Controller
    {
        private readonly AppDbContext _context;

        public SAN_PHAMController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SAN_PHAM
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.SAN_PHAMs.Include(s => s.LOAI_SAN_PHAM);
            return View(await appDbContext.ToListAsync());
        }

        // GET: SAN_PHAM/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sAN_PHAM = await _context.SAN_PHAMs
                .Include(s => s.LOAI_SAN_PHAM)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sAN_PHAM == null)
            {
                return NotFound();
            }

            return View(sAN_PHAM);
        }

        // GET: SAN_PHAM/Create
        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(_context.LOAI_SAN_PHAMs, "ID", "MaLoai");
            return View();
        }

        // POST: SAN_PHAM/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MaSanPham,TenSanPham,HinhAnh,SoLuong,DonGia,MaLoai,TrangThai")] SAN_PHAM sAN_PHAM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sAN_PHAM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoai"] = new SelectList(_context.LOAI_SAN_PHAMs, "ID", "MaLoai", sAN_PHAM.MaLoai);
            return View(sAN_PHAM);
        }

        // GET: SAN_PHAM/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sAN_PHAM = await _context.SAN_PHAMs.FindAsync(id);
            if (sAN_PHAM == null)
            {
                return NotFound();
            }
            ViewData["MaLoai"] = new SelectList(_context.LOAI_SAN_PHAMs, "ID", "MaLoai", sAN_PHAM.MaLoai);
            return View(sAN_PHAM);
        }

        // POST: SAN_PHAM/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MaSanPham,TenSanPham,HinhAnh,SoLuong,DonGia,MaLoai,TrangThai")] SAN_PHAM sAN_PHAM)
        {
            if (id != sAN_PHAM.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sAN_PHAM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SAN_PHAMExists(sAN_PHAM.ID))
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
            ViewData["MaLoai"] = new SelectList(_context.LOAI_SAN_PHAMs, "ID", "MaLoai", sAN_PHAM.MaLoai);
            return View(sAN_PHAM);
        }

        // GET: SAN_PHAM/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sAN_PHAM = await _context.SAN_PHAMs
                .Include(s => s.LOAI_SAN_PHAM)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sAN_PHAM == null)
            {
                return NotFound();
            }

            return View(sAN_PHAM);
        }

        // POST: SAN_PHAM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sAN_PHAM = await _context.SAN_PHAMs.FindAsync(id);
            if (sAN_PHAM != null)
            {
                _context.SAN_PHAMs.Remove(sAN_PHAM);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SAN_PHAMExists(int id)
        {
            return _context.SAN_PHAMs.Any(e => e.ID == id);
        }
    }
}
