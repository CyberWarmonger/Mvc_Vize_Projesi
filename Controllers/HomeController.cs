using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Vize_Projesi.Models.Entity;

namespace Mvc_Vize_Projesi.Controllers
{
    public class HomeController : Controller
    {
        vize_mvcEntities2 db = new vize_mvcEntities2();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(login log)
        {
            var user = db.login.Where(x => x.username == log.username && x.password == log.password).Count();
            if (user > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();

            }

        }
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}