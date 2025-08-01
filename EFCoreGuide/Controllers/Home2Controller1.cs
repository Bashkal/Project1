﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreGuide.Controllers
{
    public class Home2Controller1 : Controller
    {
        // GET: Home2Controller1
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home2Controller1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home2Controller1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home2Controller1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home2Controller1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home2Controller1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home2Controller1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home2Controller1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
