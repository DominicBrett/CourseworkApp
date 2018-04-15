using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CourseworkApp.Models;

namespace CourseworkApp.Controllers
{
    public class ConferenceCallResearchersController : Controller
    {
        private AppDB db = new AppDB();

        // GET: ConferenceCallResearchers
        public ActionResult Index()
        {
            return View(db.ConferenceCallResearchers.ToList());
        }

        // GET: ConferenceCallResearchers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceCallResearcher conferenceCallResearcher = db.ConferenceCallResearchers.Find(id);
            if (conferenceCallResearcher == null)
            {
                return HttpNotFound();
            }
            return View(conferenceCallResearcher);
        }

        // GET: ConferenceCallResearchers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConferenceCallResearchers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ResearcherID,ConferenceCallID")] ConferenceCallResearcher conferenceCallResearcher)
        {
            if (ModelState.IsValid)
            {
                db.ConferenceCallResearchers.Add(conferenceCallResearcher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conferenceCallResearcher);
        }

        // GET: ConferenceCallResearchers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceCallResearcher conferenceCallResearcher = db.ConferenceCallResearchers.Find(id);
            if (conferenceCallResearcher == null)
            {
                return HttpNotFound();
            }
            return View(conferenceCallResearcher);
        }

        // POST: ConferenceCallResearchers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ResearcherID,ConferenceCallID")] ConferenceCallResearcher conferenceCallResearcher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conferenceCallResearcher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conferenceCallResearcher);
        }

        // GET: ConferenceCallResearchers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceCallResearcher conferenceCallResearcher = db.ConferenceCallResearchers.Find(id);
            if (conferenceCallResearcher == null)
            {
                return HttpNotFound();
            }
            return View(conferenceCallResearcher);
        }

        // POST: ConferenceCallResearchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConferenceCallResearcher conferenceCallResearcher = db.ConferenceCallResearchers.Find(id);
            db.ConferenceCallResearchers.Remove(conferenceCallResearcher);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
