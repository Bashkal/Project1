using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitimi.Controllers
{
    public class Mvc12FileUploadController : Controller
    {
        // GET: Mvc12FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase dosya)
        {
            if (dosya != null && dosya.ContentLength>0)
            {
                var extension = Path.GetExtension(dosya.FileName);
                //if file has to be in a specific format, you can check it here
                if (extension != ".jpg" && extension != ".png")
                {
                    ViewData["Message"] = "Lütfen sadece .jpg veya .png uzantılı dosyalar yükleyiniz.";
                }
                else
                {
                    var folder = Server.MapPath("~/wwwroot/img");
                    //1.yöntem rastgele bir isim oluşturarak dosyayı kayıt etme

                    //var randomFilename = Path.GetRandomFileName();
                    //var newFileName = Path.ChangeExtension(randomFilename, ".jpg");
                    //var pathof_file = Path.Combine(folder, newFileName);

                    //2.yöntem dosyayı kendi ismi ile kayıt etme
                    var fileName = Path.GetFileName(dosya.FileName);
                    var pathof_file = Path.Combine(folder, fileName);
                    dosya.SaveAs(pathof_file);
                    ViewBag.Path = fileName;
                }
            }


            return View();
        }
    }
}