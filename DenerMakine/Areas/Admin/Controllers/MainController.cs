using DenerMakine.Data;
using Microsoft.AspNetCore.Mvc;

namespace DenerMakine.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainController : Controller
    {
        DataBaseContext _context;
        public MainController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {   
            DataBaseContext contexta = new DataBaseContext();
            return View(contexta);
        }
    }
}
