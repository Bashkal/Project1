using EFCoreGuide.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreGuide.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly EFCoreDbContext _context;
        public BrandController(EFCoreDbContext context)
        {
            _context = context;
        }
        // GET: BrandController
        public async Task<IActionResult> Index()
        {
            var brands =await _context.Brands.AsNoTracking().ToListAsync();
            return View(brands);
        }

        // GET: BrandController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            return View(brand);
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {   
            return View();
        }

        // POST: BrandController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand brand)
        {
            try
            { //  _context.Brands.Add(brand); dener denser
                //_context.Entry<Brand>(brand).State = EntityState.Added; taksan
                _context.Attach<Brand>(brand); // bu da olur
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {   //var model=_context.Brands.Where(b=>b.Id==id).FirstOrDefault();
             //var model=_context.Brands.Where(b => b.Id == id).SingleOrDefault();
             var model= _context.Brands.FirstOrDefault(b => b.Id == id);
            return View(model);
        }

        // POST: BrandController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Brand brand)
        {
            try
            { //_context.Attach<Brand>(brand).State = EntityState.Modified;
                //_context.Brands.Update(brand); // bu da olur
                // _context.Entry<Brand>(brand).State = EntityState.Modified; // bu da olur
                _context.Update(brand); // bu da olur
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {   var model =await _context.Brands.FindAsync(id);
            return View(model);
        }

        // POST: BrandController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Brand brand)
        {
            try
            {   //_context.Attach<Brand>(brand).State = EntityState.Deleted;
                //_context.Brands.Remove(brand); // bu da olur
                //_context.Entry<Brand>(brand).State = EntityState.Deleted; // bu da olur
                _context.Remove(brand); // bu da olur
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
