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
                ViewBag.SessionValue = "Session Value is null";
            }
                return View();
        }
        [HttpPost]
        public ActionResult Sessions(string text)
        {
            if (Session["SessionText"] != null)
            {
                Session.Remove("SessionText");
                //other method
                //Session["SessionText"] = null;
                ViewBag.SessionValue = "Session Value removed";
            }
            else
            {
                ViewBag.SessionValue = "Session Value is null";
            }
                return View();
        }
        [HttpPost]
        public ActionResult Cookie(string cookie)
        {   
            HttpCookie cookiee = new HttpCookie("User",cookie);
            HttpContext.Response.Cookies.Add(cookiee);
            ViewBag.Kullanici=HttpContext.Request.Cookies["User"].Value;
            return View("Index");
        }
        [HttpPost]
        public ActionResult CookieDelete()
        {
            if (HttpContext.Request.Cookies["User"] != null)
            {
               HttpContext.Response.Cookies.Remove("User");
            }
            else
            {
                ViewBag.CookieValue = "Cookie Value is not exist";
            }
            return RedirectToAction("Index");
        }
    }
}