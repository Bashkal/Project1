using MVCEgitimi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitimi.Controllers
{
    public class Mvc14CRUDController : Controller
    {
        UrunDbContext context = new UrunDbContext();
  
        // GET: Mvc14CRUD
        public ActionResult Index(string kelime)
        {
            ViewBag.Hata = "";
            if (string.IsNullOrWhiteSpace(kelime))
            {
                return View(context.Guides.ToList());
            }
            else
            {

                if (context.Guides.Any(m => m.Name.Contains(kelime)) == false)
                {
                    
                    ViewBag.Hata = "<script>alert('Aradığınız kelimeye uygun kayıt bulunamadı.');</script>\"";
                }
                    return View(context.Guides.Where(m => m.Name.Contains(kelime)).ToList());
                }
                
                
            }
            
       
        

        // GET: Mvc14CRUD/Details/5
        public ActionResult Details(int id)
        {
            Guides guide = new Guides();
            guide= context.Guides.FirstOrDefault(x => x.Id == id);

            return View(guide);
        }

        // GET: Mvc14CRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mvc14CRUD/Create
        [HttpPost]
        public ActionResult Create(Guides guides)
        {
            try
            {
                // TODO: Add insert logic here
                context.Guides.Add(guides);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mvc14CRUD/Edit/5
        public ActionResult Edit(int id)
        {
            return View(context.Guides.FirstOrDefault(x=>x.Id==id));
        }

        // POST: Mvc14CRUD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Guides guides)
        {
            try
            {
                Guides guide = context.Guides.FirstOrDefault(x => x.Id == id);
                guide.Name = guides.Name;
                guide.Description = guides.Description;
                guide.DateofChange = DateTime.Now;
                context.SaveChanges();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mvc14CRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.Guides.FirstOrDefault(x => x.Id == id));
        }

        // POST: Mvc14CRUD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                
                Guides guide = context.Guides.FirstOrDefault(x => x.Id == id);
                context.Guides.Remove(guide);
                context.SaveChanges();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
