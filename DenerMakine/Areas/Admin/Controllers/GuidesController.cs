using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DenerMakine.Data;
using DenerMakine.Entities;

namespace DenerMakine.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuidesController : Controller
    {
        private readonly DataBaseContext _context;

        public GuidesController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Admin/Guides
        public async Task<IActionResult> Index()
        {
            var dataBaseContext = _context.Guides.Include(g => g.Department);
            return View(await dataBaseContext.ToListAsync());
        }

        // GET: Admin/Guides/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guides
                .Include(g => g.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guide == null)
            {
                return NotFound();
            }

            return View(guide);
        }

        // GET: Admin/Guides/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            return View();
        }

        // POST: Admin/Guides/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Image,File,IsActive,DepartmentId")] Guide guide)
        {
            guide.CreatedDate = DateTime.Now;
            guide.UpdatedDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Add(guide);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", guide.DepartmentId);
            return View(guide);
        }

        // GET: Admin/Guides/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", guide.DepartmentId);
            return View(guide);
        }

        // POST: Admin/Guides/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Image,File,IsActive,DepartmentId")] Guide guide)
        {
            if (id != guide.Id)
            {
                return NotFound();
            }
            guide.CreatedDate = _context.Guides.AsNoTracking().FirstOrDefault(g => g.Id == id)?.CreatedDate ?? DateTime.Now;
            guide.UpdatedDate = DateTime.Now;
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Id", guide.DepartmentId);
            return View(guide);
        }

        // GET: Admin/Guides/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guide = await _context.Guides
                .Include(g => g.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guide == null)
            {
                return NotFound();
            }

            return View(guide);
        }

        // POST: Admin/Guides/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guide = await _context.Guides.FindAsync(id);
            if (guide != null)
            {
                _context.Guides.Remove(guide);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuideExists(int id)
        {
            return _context.Guides.Any(e => e.Id == id);
        }
    }
}
