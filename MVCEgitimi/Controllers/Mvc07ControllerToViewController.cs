using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitimi.Controllers
{
    public class Mvc07ControllerToViewController : Controller
    {
        // GET: Mvc07ControllerToView
        public ActionResult Index()
        {
            ViewBag.CategoryName = "Electronics";
            ViewData["ProductName"]= "Smartphone";
            TempData["Message"] = "Welcome to the Electronics section!";
            return View();
        }
    }
}