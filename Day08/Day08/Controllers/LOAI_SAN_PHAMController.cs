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
    public class LOAI_SAN_PHAMController : Controller
    {
        private readonly AppDbContext _context;

        public LOAI_SAN_PHAMController(AppDbContext context)
        {
            _context = context;
        }

        // GET: LOAI_SAN_PHAM
        public async Task<IActionResult> Index()
        {
            return View(await _context.LOAI_SAN_PHAMs.ToListAsync());
        }

        // GET: LOAI_SAN_PHAM/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lOAI_SAN_PHAM = await _context.LOAI_SAN_PHAMs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lOAI_SAN_PHAM == null)
            {
                return NotFound();
            }

            return View(lOAI_SAN_PHAM);
        }

        // GET: LOAI_SAN_PHAM/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LOAI_SAN_PHAM/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MaLoai,TenLoai,TrangThai")] LOAI_SAN_PHAM lOAI_SAN_PHAM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lOAI_SAN_PHAM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lOAI_SAN_PHAM);
        }

        // GET: LOAI_SAN_PHAM/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lOAI_SAN_PHAM = await _context.LOAI_SAN_PHAMs.FindAsync(id);
            if (lOAI_SAN_PHAM == null)
            {
                return NotFound();
            }
            return View(lOAI_SAN_PHAM);
        }

        // POST: LOAI_SAN_PHAM/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MaLoai,TenLoai,TrangThai")] LOAI_SAN_PHAM lOAI_SAN_PHAM)
        {
            if (id != lOAI_SAN_PHAM.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lOAI_SAN_PHAM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LOAI_SAN_PHAMExists(lOAI_SAN_PHAM.ID))
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
            return View(lOAI_SAN_PHAM);
        }

        // GET: LOAI_SAN_PHAM/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lOAI_SAN_PHAM = await _context.LOAI_SAN_PHAMs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lOAI_SAN_PHAM == null)
            {
                return NotFound();
            }

            return View(lOAI_SAN_PHAM);
        }

        // POST: LOAI_SAN_PHAM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lOAI_SAN_PHAM = await _context.LOAI_SAN_PHAMs.FindAsync(id);
            if (lOAI_SAN_PHAM != null)
            {
                _context.LOAI_SAN_PHAMs.Remove(lOAI_SAN_PHAM);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LOAI_SAN_PHAMExists(int id)
        {
            return _context.LOAI_SAN_PHAMs.Any(e => e.ID == id);
        }
    }
}
