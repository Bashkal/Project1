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

        public IActionResult Index(string Search)
        {
            ViewBag.DepartmanAdi = "BT";
            ViewBag.KilavuzAdi = "Deneme";
            ViewBag.Tarih = DateTime.Now.ToString();
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Dep, string Gui, string Date)
        {
            ViewBag.DepartmanAdi = Dep;
            ViewBag.KilavuzAdi = Gui;
            ViewBag.Tarih = Date;
            return View();
        }

        public IActionResult Privacy()
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
