using DenerMakine.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DenerMakine.Controllers
{
    public class GuidesController : Controller
    {
        private readonly DataBaseContext _context;
        public GuidesController(DataBaseContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> IndexAsync()
        {
            var model =await _context.Guides.Include(g=>g.Department).ToListAsync();
            return View(model);
        }
        public async Task <IActionResult> DetailsAsync(int id)
        {
            var model =await _context.Guides.FindAsync(id);
            return View(model);
        }
        public async Task<IActionResult> SearchAsync(string? search)
        {
            var model = await _context.Guides.Include(g => g.Department).Where(p => p.Name.Contains(search)||p.Description.Contains(search)||p.Department.Name.Contains(search)).ToListAsync();
            return View(model);
        }
    }
}
