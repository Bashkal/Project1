using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEgitimi.Models;

namespace MVCEgitimi.Controllers
{
    public class Mvc09ModelBindingController : Controller
    {
        // GET: Mvc09ModelBinding
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult User()
        {
            User user=new User() { Name="Mahmut Sami",Surname="Başkal",Age=20, Department="BT", Email="mahmutsamibaskal@gmail.com", Password="Bashkal3360", UserName="Bashkal"};
            return View(user);
        }
        [HttpPost]
        
        public ActionResult User(User user)
        {   ViewBag.Message = "Kullanıcı Adı: " + user.UserName;
            ViewBag.Message1 = "Şifre: " + user.Password;   
            ViewBag.Message2 = "Ad: " + user.Name;
            ViewBag.Message3 = "Soyad: " + user.Surname;
            ViewBag.Message4 = "Yaş: " + user.Age;
            ViewBag.Message5 = "E-posta: " + user.Email;
             
            return View(user);
        }
    }
}