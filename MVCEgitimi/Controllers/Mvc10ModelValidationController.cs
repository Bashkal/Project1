using MVCEgitimi.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        {
            if (ModelState.IsValid)
                ViewBag.UyeBilgi = $"Ad: {uye.Ad}<br/> Soyad: {uye.Soyad}<br/> Eposta: {uye.Eposta}<br/> Kullanıcı Adı: {uye.KullaniciAdi}<br/> TC Kimlik No: {uye.TcKimlikNo}<br/> Telefon: {uye.Telefon}<br/> Şifre: {uye.Sifre}<br/> Doğum Tarihi: {uye.DogumTarihi.ToString("dd.MM.yyyy")}";
            else
            {
                ViewBag.UyeBilgi = "Model Validasyonu Hatası";
                return View(uye);
            }
            return View();
        }
        public ActionResult UyeDuzenle(int id)
        {
            
            return View();
        }
        public ActionResult UyeSil()
        {
            var uyelistesi = new List<Uye>()
            {
                new Uye()
                {
                    Id=1,
                    Ad="Ali",
                    Soyad="Yılmaz",
                    Eposta=""
            },
                new Uye()
                {
                    Id=2,
                    Ad="Ayşe",
                    Soyad="Demir",
                    Eposta=""
            }};

            return View(uyelistesi);
        }
        public ActionResult UyeListele()
        {
            var uyelistesi = new List<Uye>()
            {
                new Uye()
                {
                    Id=1,
                    Ad="Ali",
                    Soyad="Yılmaz",
                    Eposta=""
            },
                new Uye()
                {
                    Id=2,
                    Ad="Ayşe",
                    Soyad="Demir",
                    Eposta=""
            }};
            return View(uyelistesi);
        }
    }
}