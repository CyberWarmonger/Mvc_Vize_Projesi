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
    }
}