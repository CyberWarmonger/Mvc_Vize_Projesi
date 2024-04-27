using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Vize_Projesi.Models.Entity;


namespace Mvc_Vize_Projesi.Controllers
{
    public class RaporlarController : Controller
    {
        vize_mvcEntities2 db = new vize_mvcEntities2();

        // GET: Raporlar
        public ActionResult Index()
        {
            var rapor = db.Tbl_Ogrenci.ToList();
            return View(rapor);
        }
    }
}