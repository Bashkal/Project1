using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApplication.Models
{
    public class DepGuiController : Controller
    {
        NetCoreWebApplicationDBContext _context;
      public Guide Guides { get; set;
        }
        public Department Departments { get; set;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
