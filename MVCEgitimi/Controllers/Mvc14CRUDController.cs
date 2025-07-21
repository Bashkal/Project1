using MVCEgitimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitimi.Controllers
{
    public class Mvc14CRUDController : Controller
    {
        UrunDbContext context = new UrunDbContext();
  
        // GET: Mvc14CRUD
        public ActionResult Index()
        {
            return View(context.Guides.ToList());
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
            return View(context.Categories.ToList());
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
            return View();
        }

        // POST: Mvc14CRUD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
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
            return View();
        }

        // POST: Mvc14CRUD/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
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
