using Mvc_Vize_Projesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Vize_Projesi.Models.Entity;


namespace Mvc_Vize_Projesi.Controllers
{
    public class idareController : Controller
    {
        vize_mvcEntities2 db = new vize_mvcEntities2();

        // GET: idare
        public ActionResult Index()
        {
            var idare = db.Tbl_Idare.ToList();
            return View(idare);
        }
        public ActionResult Sil(int id)
        {
            var idare = db.Tbl_Idare.Find(id);
            db.Tbl_Idare.Remove(idare);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}