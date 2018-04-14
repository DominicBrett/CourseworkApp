using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseworkApp.Models;
namespace CourseworkApp.Controllers
{
    public class HomeController : Controller
    {
        AppDB db = new AppDB();

        public ActionResult Index()
        {
            return View(db.Events.ToList());
        }
        public ActionResult Reports()
        {
            return View(db.Reports.ToList());
        }
        public ActionResult ConferenceCalls()
        {
            return View(db.ConferenceCalls.ToList()); 
        }
        public ActionResult Publications()
        {
            return View(db.Publications.ToList());
        }
        public ActionResult AdminPanel()
        {
            return View();  
        }  
       
        public ActionResult About()
        {
            return View(db.Researchers.ToList());
        }

        public ActionResult Contact()
        {
            return View(db.Researchers.ToList());
        }
    }
}