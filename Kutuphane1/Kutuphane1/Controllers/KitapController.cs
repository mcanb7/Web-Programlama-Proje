using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kutuphane1.Data;
using Kutuphane1.Models;

namespace Kutuphane1.Controllers
{
    public class KitapController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KitapController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Kitap
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Kitap.Include(k => k.Kategori).Include(k => k.Yazar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Kitap/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitap = await _context.Kitap
                .Include(k => k.Kategori)
                .Include(k => k.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kitap == null)
            {
                return NotFound();
            }

            return View(kitap);
        }

        // GET: Kitap/Create
        public IActionResult Create()
        {
            ViewData["KategoriId"] = new SelectList(_context.Set<Kategori>(), "Id", "Id");
            ViewData["YazarId"] = new SelectList(_context.Set<Yazar>(), "Id", "Id");
            return View();
        }

        // POST: Kitap/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,KitapAdi,KitapYazari,KitapCikis,KitapEklenme,KtokAdedi,KategoriId,YazarId")] Kitap kitap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kitap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategoriId"] = new SelectList(_context.Set<Kategori>(), "Id", "Id", kitap.KategoriId);
            ViewData["YazarId"] = new SelectList(_context.Set<Yazar>(), "Id", "Id", kitap.YazarId);
            return View(kitap);
        }

        // GET: Kitap/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitap = await _context.Kitap.FindAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }
            ViewData["KategoriId"] = new SelectList(_context.Set<Kategori>(), "Id", "Id", kitap.KategoriId);
            ViewData["YazarId"] = new SelectList(_context.Set<Yazar>(), "Id", "Id", kitap.YazarId);
            return View(kitap);
        }

        // POST: Kitap/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,KitapAdi,KitapYazari,KitapCikis,KitapEklenme,KtokAdedi,KategoriId,YazarId")] Kitap kitap)
        {
            if (id != kitap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kitap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KitapExists(kitap.Id))
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
            ViewData["KategoriId"] = new SelectList(_context.Set<Kategori>(), "Id", "Id", kitap.KategoriId);
            ViewData["YazarId"] = new SelectList(_context.Set<Yazar>(), "Id", "Id", kitap.YazarId);
            return View(kitap);
        }

        // GET: Kitap/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kitap = await _context.Kitap
                .Include(k => k.Kategori)
                .Include(k => k.Yazar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kitap == null)
            {
                return NotFound();
            }

            return View(kitap);
        }

        // POST: Kitap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kitap = await _context.Kitap.FindAsync(id);
            _context.Kitap.Remove(kitap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KitapExists(int id)
        {
            return _context.Kitap.Any(e => e.Id == id);
        }
    }
}
