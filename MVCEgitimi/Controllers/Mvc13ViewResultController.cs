using MVCEgitimi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitimi.Controllers
{
    public class Mvc13ViewResultController : Controller
    {
        // GET: Mvc13ViewResult
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult Index2()
        {
            return Redirect("/Home/Index");
        }
        public RedirectToRouteResult Index3()
        {
            return RedirectToRoute("Default", new { controller = "Home", action = "Index" });
        }
        public PartialViewResult KategorileriPartialIleGetir()
        {
            return PartialView("_KategorilerPartial");
        }
        public PartialViewResult KategorileriModelIleGetir()
        {
            List<string> kategoriler = new List<string>(){
            "Bilgisayarlar",
            "Monitörler",
            "Kalvyeler",
            "Mouselar"};

            return PartialView("_KategorilerPartial2", kategoriler);
        }
        public FileResult PDFDosyaIndir()
        {
            string dosyaYolu = Server.MapPath("~/wwwroot/IFS Cloud Course Catalogue for Customers.pdf");
            return new FilePathResult(dosyaYolu, "application/pdf");
        }
        public FileStreamResult MetinDosyaIndir()
        {
            string dosyaYolu = Server.MapPath("~/wwwroot/notlar.txt");
            var stream = new System.IO.FileStream(dosyaYolu, System.IO.FileMode.Open);
            return new FileStreamResult(stream, "text/plain")
            {
                FileDownloadName = "Notes.txt"
            };
        }
        public FileStreamResult MetinDosyasiIndir()
        {
            string metin = "Merhaba, bu bir metin dosyasıdır.";
            MemoryStream memoryStream = new MemoryStream();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(metin);
            memoryStream.Write(bytes, 0, bytes.Length);
            memoryStream.Position = 0;
            FileStreamResult result = new FileStreamResult(memoryStream, "text/plain");
            result.FileDownloadName = "metin.txt";
            return result;


        }
        public JavaScriptResult JavaScriptResultOrnegi()
        {
            string script = "alert('Merhaba, bu bir JavaScript alert mesajıdır!');";
            return new JavaScriptResult { Script = script };
        }
        public JavaScriptResult JSClick()
        {
            string script = "function button_click(){ alert('Merhaba, bu bir JavaScript alert mesajıdır!')}";
            return new JavaScriptResult { Script = script };
        }
        public JsonResult Index4()
        {
            User user = new User
            {
                /*{
  "Name": "Ahmet",
  "Surname": "Yılmaz",
  "Email": "msb@gmail.com",
  "Password": null,
  "BirthDate": "/Date(-62135596800000)/",
  "IsActive": false,
  "Age": 0,
  "UserName": null,
  "Department": null
}*/
                Name = "Ahmet",
                Surname = "Yılmaz",
                Email = "msb@gmail.com"
            };

            return Json(user,JsonRequestBehavior.AllowGet);
        }
        public ContentResult Index5()
        {
            var xml = @"
<kullanicilar>
                        <kullanici>
                        <Id>1</Id>
                        <Name>Mahmut</Name>
                        <Age>20</Age>
                        </kullanici>
,<kullanici>
                        <Id>2</Id>
                        <Name>Sami</Name>
                        <Age>2312</Age>
                        </kullanici>
</kullanicilar>";
            return Content(xml, "application/xml");
        }


    }
}