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

    }
}