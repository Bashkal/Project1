using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Deneme_Sitesi.Data;
using Deneme_Sitesi.Models;

namespace Deneme_Sitesi.Controllers
{
    public class GuidesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuidesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Guides
        public async Task<IActionResult> Index()
        {
            return View(await _context.Guides.ToListAsync());
        }

        // GET: Guides/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guides
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guide == null)
            {
                return NotFound();
            }

            return View(guide);
        }

        // GET: Guides/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guides/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,DateOnly")] Guide guide)
        {
            if (ModelState.IsValid)
            {
                guide.Id = Guid.NewGuid();
                _context.Add(guide);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guide);
        }

        // GET: Guides/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guides.FindAsync(id);
            if (guide == null)
            {
                return NotFound();
            }
            return View(guide);
        }

        // POST: Guides/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Description,DateOnly")] Guide guide)
        {
            if (id != guide.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guide);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuideExists(guide.Id))
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
            return View(guide);
        }
        // GET: Guides/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var guide = await _context.Guides
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guide == null)
            {
                return NotFound();
            }
            return View(guide);
        }
        // POST: Guides/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var guide = await _context.Guides.FindAsync(id);
            if (guide != null)
            {
                _context.Guides.Remove(guide);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuideExists(Guid id)
        {
            return _context.Guides.Any(e => e.Id == id);
        }
    }
}
