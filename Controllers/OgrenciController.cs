using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Vize_Projesi.Models.Entity;

namespace Mvc_Vize_Projesi.Controllers
{
    public class OgrenciController : Controller
    {
        vize_mvcEntities db = new vize_mvcEntities();
        // GET: Ogrenci
        public ActionResult Index()
        {
            var ogrenciler = db.Tbl_Ogrenci.ToList();
            return View(ogrenciler);
        }
    }
}