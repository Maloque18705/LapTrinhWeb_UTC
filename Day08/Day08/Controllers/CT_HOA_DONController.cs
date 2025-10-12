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
    public class CT_HOA_DONController : Controller
    {
        private readonly AppDbContext _context;

        public CT_HOA_DONController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CT_HOA_DON
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CT_HOA_DONs.Include(c => c.HOA_DON).Include(c => c.SAN_PHAM);
            return View(await appDbContext.ToListAsync());
        }

        // GET: CT_HOA_DON/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cT_HOA_DON = await _context.CT_HOA_DONs
                .Include(c => c.HOA_DON)
                .Include(c => c.SAN_PHAM)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cT_HOA_DON == null)
            {
                return NotFound();
            }

            return View(cT_HOA_DON);
        }

        // GET: CT_HOA_DON/Create
        public IActionResult Create()
        {
            ViewData["HoaDonID"] = new SelectList(_context.HOA_DONs, "ID", "MaHoaDon");
            ViewData["SanPhamID"] = new SelectList(_context.SAN_PHAMs, "ID", "MaSanPham");
            return View();
        }

        // POST: CT_HOA_DON/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,HoaDonID,SanPhamID,SoLuongMua,DonGiaMua,TrangThai")] CT_HOA_DON cT_HOA_DON)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cT_HOA_DON);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HoaDonID"] = new SelectList(_context.HOA_DONs, "ID", "MaHoaDon", cT_HOA_DON.HoaDonID);
            ViewData["SanPhamID"] = new SelectList(_context.SAN_PHAMs, "ID", "MaSanPham", cT_HOA_DON.SanPhamID);
            return View(cT_HOA_DON);
        }

        // GET: CT_HOA_DON/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cT_HOA_DON = await _context.CT_HOA_DONs.FindAsync(id);
            if (cT_HOA_DON == null)
            {
                return NotFound();
            }
            ViewData["HoaDonID"] = new SelectList(_context.HOA_DONs, "ID", "MaHoaDon", cT_HOA_DON.HoaDonID);
            ViewData["SanPhamID"] = new SelectList(_context.SAN_PHAMs, "ID", "MaSanPham", cT_HOA_DON.SanPhamID);
            return View(cT_HOA_DON);
        }

        // POST: CT_HOA_DON/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,HoaDonID,SanPhamID,SoLuongMua,DonGiaMua,TrangThai")] CT_HOA_DON cT_HOA_DON)
        {
            if (id != cT_HOA_DON.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cT_HOA_DON);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CT_HOA_DONExists(cT_HOA_DON.ID))
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
            ViewData["HoaDonID"] = new SelectList(_context.HOA_DONs, "ID", "MaHoaDon", cT_HOA_DON.HoaDonID);
            ViewData["SanPhamID"] = new SelectList(_context.SAN_PHAMs, "ID", "MaSanPham", cT_HOA_DON.SanPhamID);
            return View(cT_HOA_DON);
        }

        // GET: CT_HOA_DON/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cT_HOA_DON = await _context.CT_HOA_DONs
                .Include(c => c.HOA_DON)
                .Include(c => c.SAN_PHAM)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cT_HOA_DON == null)
            {
                return NotFound();
            }

            return View(cT_HOA_DON);
        }

        // POST: CT_HOA_DON/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cT_HOA_DON = await _context.CT_HOA_DONs.FindAsync(id);
            if (cT_HOA_DON != null)
            {
                _context.CT_HOA_DONs.Remove(cT_HOA_DON);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CT_HOA_DONExists(int id)
        {
            return _context.CT_HOA_DONs.Any(e => e.ID == id);
        }
    }
}
