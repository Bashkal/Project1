using Microsoft.AspNetCore.Mvc;
using NetCoreWebApplication.Models;

namespace NetCoreWebApplication.Controllers
{
    public class ViewResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FileUpload()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FileUpload(IFormFile Image)
        {
            if (Image is not null)
            {
                string path =Directory.GetCurrentDirectory()+ "/wwwroot/Document/"+ Image.FileName;
                using var stream = new FileStream(path, FileMode.Create);
                Image.CopyTo(stream);
                TempData["path"]= Image.FileName;
            }
            
            
            return View();
        }
        
        public IActionResult Yonlendir()
        {
            return Redirect("/Home/Index");
        }
        public IActionResult ActionYönlendir()
        {
            return RedirectToAction("Index", "Home");
        }
        public IActionResult RouteYönlendir()
        {
            return RedirectToRoute("default", new
            {
                controller = "Guides",
                action = "Index"
            });
        }
        public JsonResult JsonDondur()
        {
            var guide = new
            {
                Id = Guid.NewGuid(),
                Name = "Sample Guide",
                DepartmentId = "IT",
                Description = "This is a sample guide.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CreatedBy = "Admin",
                Path = "/files/sample-guide.pdf"
            };
            return Json(guide);
        }
        public IActionResult XmlContent()
        {
            var xml = @"
                <Guide>
                    <Name>Sample Guide</Name>
                    <DepartmentId>IT</DepartmentId>
                    <Description>This is a sample guide.</Description>
                    <CreatedDate>2023-10-01</CreatedDate>
                    <UpdatedDate>2023-10-01</UpdatedDate>
                    <CreatedBy>Admin</CreatedBy>
                    <Path>/files/sample-guide.pdf</Path>
                </Guide>
               ";
            return Content(xml, "application/xml");
        }
    }
}
