using DagKeys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DagKeys.Controllers
{
    public class HomeController : Controller
    {
        private DataEntities db = new DataEntities();
        public ActionResult Index()
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
        public ActionResult List()
        {
            ViewBag.Message = "List of supporters";
            var list = db.Supporters.ToList();
            if(list.Count == 0)
            {
                return View("about");
            }else
            return View(list);
        }

    }
}