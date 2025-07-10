using MVCEgitimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEgitimi.Controllers
{
    public class Mvc10ModelValidationController : Controller
    {
        // GET: Mvc10ModelValidation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]

        public ActionResult YeniUye(Uye uye)
        { if(ModelState.IsValid)
            ViewBag.UyeBilgi = $"Ad: {uye.Ad}<br/> Soyad: {uye.Soyad}<br/> Eposta: {uye.Eposta}<br/> Kullanıcı Adı: {uye.KullaniciAdi}<br/> TC Kimlik No: {uye.TcKimlikNo}<br/> Telefon: {uye.Telefon}<br/> Şifre: {uye.Sifre}<br/> Doğum Tarihi: {uye.DogumTarihi.ToString("dd.MM.yyyy")}";
            else
            {
                ViewBag.UyeBilgi = "Model Validasyonu Hatası";
                return View(uye);
            }
            return View();
        }
    }
}