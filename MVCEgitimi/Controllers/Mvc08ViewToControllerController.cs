using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitimi.Controllers
{
    public class Mvc08ViewToControllerController : Controller
    {
        // GET: Mvc08ViewToController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string text1,bool cbonay,string liste)

        {   /*
             * Burası değişkenleri yukarıda tanımlamadığımız zaman kullanılabilir.
             * var txtboxValue = Request.Form["text1"];
            var dropdownValue = Request.Form["liste"];
            var checkboxValue = Request.Form.GetValues("cbonay")[0];

            ViewBag.Message = "TextBox: " + txtboxValue;
            ViewBag.Message1 = "DropDown: " + dropdownValue;
            ViewBag.Message2 = "CheckBox: " + checkboxValue;
            */
            ViewBag.Message = "TextBox: " + text1;
            ViewBag.Message1 = "DropDown: " + cbonay;
            ViewBag.Message2 = "CheckBox: " + liste;

            return View();
        }
    }
}