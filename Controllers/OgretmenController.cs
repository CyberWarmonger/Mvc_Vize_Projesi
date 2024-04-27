using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Vize_Projesi.Models.Entity;


namespace Mvc_Vize_Projesi.Controllers
{
    public class OgretmenController : Controller
    {
        // GET: Ogretmen
        vize_mvcEntities2 db = new vize_mvcEntities2();
        public ActionResult Index()
        {
            var ogretmenler = db.Tbl_Ogretmen.ToList();
            return View(ogretmenler);
        }
        [HttpGet]
        public ActionResult YeniOgretmen()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniOgretmen(Tbl_Ogretmen p1) 
        {
            db.Tbl_Ogretmen.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var ogretmen = db.Tbl_Ogretmen.Find(id);
            db.Tbl_Ogretmen.Remove(ogretmen);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OgretmenGetir(int id)
        {
            var ogretmen = db.Tbl_Ogretmen.Find(id);
            return View("OgretmenGetir", ogretmen);
        }
        public ActionResult Guncelle(Tbl_Ogretmen p1)
        {
            var ogr = db.Tbl_Ogretmen.Find(p1.ogretmenid);
            ogr.OgretmenBolum = p1.OgretmenBolum;
            ogr.OgretmenAd = p1.OgretmenAd;
            ogr.OgretmenSoyad = p1.OgretmenSoyad;
            ogr.OgretmenGiris = p1.OgretmenGiris;
            ogr.OgretmenCikis = p1.OgretmenCikis;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}