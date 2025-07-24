using Microsoft.AspNetCore.Mvc;
using NetCoreWebApplication.Models;
using System.Diagnostics;

namespace NetCoreWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy(string Search)
        {
            ViewBag.DepartmanAdi = "BT";
            ViewBag.KilavuzAdi = "Deneme";
            ViewBag.Tarih = DateTime.Now.ToString();
            //cookie öreði
            ViewBag.CookieDepartman = Request.Cookies["Departman"];
            //Session
            ViewBag.Session=HttpContext.Session.GetString("Date");
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(string Dep, string Gui, string Date)
        {
            ViewBag.DepartmanAdi = Dep;
            ViewBag.KilavuzAdi = Gui;
            ViewBag.Tarih = Date;
            //cookie örnek
            Response.Cookies.Append("Departman", Dep);

            //Session Usage
            HttpContext.Session.SetString("Date", Date);

            return RedirectToAction("Privacy");
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
