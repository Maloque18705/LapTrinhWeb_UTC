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
    public class HOA_DONController : Controller
    {
        private readonly AppDbContext _context;

        public HOA_DONController(AppDbContext context)
        {
            _context = context;
        }

        // GET: HOA_DON
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.HOA_DONs.Include(h => h.KHACH_HANG);
            return View(await appDbContext.ToListAsync());
        }

        // GET: HOA_DON/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOA_DON = await _context.HOA_DONs
                .Include(h => h.KHACH_HANG)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hOA_DON == null)
            {
                return NotFound();
            }

            return View(hOA_DON);
        }

        // GET: HOA_DON/Create
        public IActionResult Create()
        {
            ViewData["MaKhachHang"] = new SelectList(_context.KHACH_HANGs, "ID", "HoTenKhachHang");
            return View();
        }

        // POST: HOA_DON/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MaHoaDon,MaKhachHang,NgayHoaDon,NgayNhan,HoTenKhachHang,Email,DienThoai,DiaChi,TongTriGia,TrangThai")] HOA_DON hOA_DON)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hOA_DON);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKhachHang"] = new SelectList(_context.KHACH_HANGs, "ID", "HoTenKhachHang", hOA_DON.MaKhachHang);
            return View(hOA_DON);
        }

        // GET: HOA_DON/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOA_DON = await _context.HOA_DONs.FindAsync(id);
            if (hOA_DON == null)
            {
                return NotFound();
            }
            ViewData["MaKhachHang"] = new SelectList(_context.KHACH_HANGs, "ID", "HoTenKhachHang", hOA_DON.MaKhachHang);
            return View(hOA_DON);
        }

        // POST: HOA_DON/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MaHoaDon,MaKhachHang,NgayHoaDon,NgayNhan,HoTenKhachHang,Email,DienThoai,DiaChi,TongTriGia,TrangThai")] HOA_DON hOA_DON)
        {
            if (id != hOA_DON.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hOA_DON);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HOA_DONExists(hOA_DON.ID))
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
            ViewData["MaKhachHang"] = new SelectList(_context.KHACH_HANGs, "ID", "HoTenKhachHang", hOA_DON.MaKhachHang);
            return View(hOA_DON);
        }

        // GET: HOA_DON/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hOA_DON = await _context.HOA_DONs
                .Include(h => h.KHACH_HANG)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hOA_DON == null)
            {
                return NotFound();
            }

            return View(hOA_DON);
        }

        // POST: HOA_DON/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hOA_DON = await _context.HOA_DONs.FindAsync(id);
            if (hOA_DON != null)
            {
                _context.HOA_DONs.Remove(hOA_DON);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HOA_DONExists(int id)
        {
            return _context.HOA_DONs.Any(e => e.ID == id);
        }
    }
}
