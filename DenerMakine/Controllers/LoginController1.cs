using Microsoft.AspNetCore.Mvc;

namespace DenerMakine.Controllers
{
    public class LoginController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {

            return RedirectToAction("Index", "Home");
        }
        public IActionResult SignIn()
        {
            return View();
        }

    }
}
