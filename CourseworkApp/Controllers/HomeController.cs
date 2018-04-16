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
        public PartialViewResult EventsSearch(string q)
        {
            var _searchResult = db.Events.Where(r => r.EventName.Contains(q) || string.IsNullOrEmpty(q)).Take(10);
            return PartialView("_Events", _searchResult);
        }
        public PartialViewResult ReportsSearch(string q)
        {
            var _searchResult = db.Reports.Where(r => r.ReportTitle.Contains(q) || string.IsNullOrEmpty(q)).Take(10);
            return PartialView("_Reports", _searchResult);
        }
        public PartialViewResult AboutSearch(string q)
        {
            var _searchResult = db.Researchers.Where(r => r.Name.Contains(q) || string.IsNullOrEmpty(q)).Take(10);
            return PartialView("_ResearchersAbout", _searchResult);
        }
        public PartialViewResult ContactSearch(string q)
        {
            var _searchResult = db.Researchers.Where(r => r.Name.Contains(q) || string.IsNullOrEmpty(q)).Take(10);
            return PartialView("_ResearchersContact", _searchResult);
        }
        public PartialViewResult PublicationsSearch(string q)
        {
            var _searchResult = db.Publications.Where(r => r.PublicationTitle.Contains(q) || string.IsNullOrEmpty(q)).Take(10);
            return PartialView("_Publications", _searchResult);
        }
        public PartialViewResult ConferenceCallsSearch(string q)
        {
            var _searchResult = db.ConferenceCalls.Where(r => r.ConferenceCallTitle.Contains(q) || string.IsNullOrEmpty(q)).Take(10);
            return PartialView("_ConferenceCalls", _searchResult);
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