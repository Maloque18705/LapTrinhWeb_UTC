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
    public class KHACH_HANGController : Controller
    {
        private readonly AppDbContext _context;

        public KHACH_HANGController(AppDbContext context)
        {
            _context = context;
        }

        // GET: KHACH_HANG
        public async Task<IActionResult> Index()
        {
            return View(await _context.KHACH_HANGs.ToListAsync());
        }

        // GET: KHACH_HANG/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kHACH_HANG = await _context.KHACH_HANGs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kHACH_HANG == null)
            {
                return NotFound();
            }

            return View(kHACH_HANG);
        }

        // GET: KHACH_HANG/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KHACH_HANG/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MaKhachHang,HoTenKhachHang,Email,MatKhau,DienThoai,DiaChi,NgayDangKy,TrangThai")] KHACH_HANG kHACH_HANG)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kHACH_HANG);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kHACH_HANG);
        }

        // GET: KHACH_HANG/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kHACH_HANG = await _context.KHACH_HANGs.FindAsync(id);
            if (kHACH_HANG == null)
            {
                return NotFound();
            }
            return View(kHACH_HANG);
        }

        // POST: KHACH_HANG/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MaKhachHang,HoTenKhachHang,Email,MatKhau,DienThoai,DiaChi,NgayDangKy,TrangThai")] KHACH_HANG kHACH_HANG)
        {
            if (id != kHACH_HANG.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kHACH_HANG);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KHACH_HANGExists(kHACH_HANG.ID))
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
            return View(kHACH_HANG);
        }

        // GET: KHACH_HANG/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kHACH_HANG = await _context.KHACH_HANGs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kHACH_HANG == null)
            {
                return NotFound();
            }

            return View(kHACH_HANG);
        }

        // POST: KHACH_HANG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kHACH_HANG = await _context.KHACH_HANGs.FindAsync(id);
            if (kHACH_HANG != null)
            {
                _context.KHACH_HANGs.Remove(kHACH_HANG);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KHACH_HANGExists(int id)
        {
            return _context.KHACH_HANGs.Any(e => e.ID == id);
        }
    }
}
