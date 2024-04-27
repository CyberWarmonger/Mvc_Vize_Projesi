using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;
using Mvc_Vize_Projesi.Models.Entity;

namespace Mvc_Vize_Projesi.Controllers
{
    public class OgrenciController : Controller
    {
        vize_mvcEntities2 db = new vize_mvcEntities2();
        // GET: Ogrenci
        public ActionResult Index()
        {
            var ogrenciler = db.Tbl_Ogrenci.ToList();
            return View(ogrenciler);
        }
        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniOgrenci(Tbl_Ogrenci p1)
        {
            db.Tbl_Ogrenci.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var ogrenci = db.Tbl_Ogrenci.Find(id);
            db.Tbl_Ogrenci.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OgrenciGetir(int id) 
        {
            var ogr = db.Tbl_Ogrenci.Find(id);
            return View("OgrenciGetir", ogr);
        }
        public ActionResult Guncelle(Tbl_Ogrenci p1)
        {
            var ogr = db.Tbl_Ogrenci.Find(p1.ogreinciid);
            ogr.OgrenciBolum = p1.OgrenciBolum;
            ogr.OgrenciAdSoyad = p1.OgrenciAdSoyad;
            ogr.OgrenciNo = p1.OgrenciNo;
            ogr.OgrenciKredi = p1.OgrenciKredi;

            // Öğrencinin kredi sayısını kontrol et
            if (p1.OgrenciKredi <= 50)
            {
                // 50 kredi altında ise, hata mesajı ekleyin ve tekrar Guncelle sayfasını gösterin
                ModelState.AddModelError(string.Empty, "Öğrenci 50 kredi altında olduğu için mezun olamaz.");
                return View(p1);
            }

            // 50 kredi üstünde ise, mezun olmasına izin ver
            ogr.OgrenciMezun = true;

            if (ModelState.IsValid)
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Eğer model doğrulama başarısız olursa, formu tekrar göster
            return View(p1);
        }
    }
}