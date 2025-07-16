using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitimi.Controllers
{
    public class Mvc11SessionCookieController : Controller
    {
        // GET: Mvc11SessionCookie
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text)
        {
            //session değer atama 
            Session["SessionText"] = text;
            //Dİğer method
            //Session.Add("SessionText", text);
            return View();
        }
        public ActionResult Sessions()
        {
            if (Session["SessionText"] != null)
            {
                ViewBag.SessionValue = Session["SessionText"].ToString();
            }
            else
            {
                ViewBag.SessionValue = "Session Value is null"
            }

                return View();
        }
    }
}