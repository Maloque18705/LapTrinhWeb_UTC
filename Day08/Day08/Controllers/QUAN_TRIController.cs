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
    public class QUAN_TRIController : Controller
    {
        private readonly AppDbContext _context;

        public QUAN_TRIController(AppDbContext context)
        {
            _context = context;
        }

        // GET: QUAN_TRI
        public async Task<IActionResult> Index()
        {
            return View(await _context.QUAN_TRIs.ToListAsync());
        }

        // GET: QUAN_TRI/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qUAN_TRI = await _context.QUAN_TRIs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qUAN_TRI == null)
            {
                return NotFound();
            }

            return View(qUAN_TRI);
        }

        // GET: QUAN_TRI/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QUAN_TRI/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TaiKhoan,MatKhau,TrangThai")] QUAN_TRI qUAN_TRI)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qUAN_TRI);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qUAN_TRI);
        }

        // GET: QUAN_TRI/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qUAN_TRI = await _context.QUAN_TRIs.FindAsync(id);
            if (qUAN_TRI == null)
            {
                return NotFound();
            }
            return View(qUAN_TRI);
        }

        // POST: QUAN_TRI/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TaiKhoan,MatKhau,TrangThai")] QUAN_TRI qUAN_TRI)
        {
            if (id != qUAN_TRI.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qUAN_TRI);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QUAN_TRIExists(qUAN_TRI.ID))
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
            return View(qUAN_TRI);
        }

        // GET: QUAN_TRI/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qUAN_TRI = await _context.QUAN_TRIs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (qUAN_TRI == null)
            {
                return NotFound();
            }

            return View(qUAN_TRI);
        }

        // POST: QUAN_TRI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qUAN_TRI = await _context.QUAN_TRIs.FindAsync(id);
            if (qUAN_TRI != null)
            {
                _context.QUAN_TRIs.Remove(qUAN_TRI);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QUAN_TRIExists(int id)
        {
            return _context.QUAN_TRIs.Any(e => e.ID == id);
        }
    }
}
