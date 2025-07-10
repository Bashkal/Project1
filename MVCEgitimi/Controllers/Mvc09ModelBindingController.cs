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
            var sayfa = new UseModelsTogetherInSamePage()
            {
                UserObject = new User() { Name = "Mahmut Sami", Surname = "Başkal", Age = 20, Department = "BT", Email = "mahmutsamibaskal@gmail.com", Password = "Bashkal3360", UserName = "Bashkal", BirthDate=new DateTime(2005,02,11), IsActive = true },
                AddressObject = new Address() { City = "İstanbul", Region = "Kadıköy", FullAdress = "Caferağa Mah. Kadıköy/İstanbul" }


            };            return View(sayfa);
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
        public ActionResult Address()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Address(Address address)
        {
            ViewBag.Message = "Şehir: " + address.City;
            ViewBag.Message1 = "İlçe: " + address.Region;
            ViewBag.Message2 = "Açık Adres: " + address.FullAdress;

            return View();
        }
    }
}