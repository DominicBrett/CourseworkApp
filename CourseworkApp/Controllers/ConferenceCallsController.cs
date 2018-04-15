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
    public class ConferenceCallsController : Controller
    {
        private AppDB db = new AppDB();

        // GET: ConferenceCalls
        public ActionResult Index()
        {
            return View(db.ConferenceCalls.ToList());
        }

        // GET: ConferenceCalls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceCall conferenceCall = db.ConferenceCalls.Find(id);
            if (conferenceCall == null)
            {
                return HttpNotFound();
            }
            return View(conferenceCall);
        }

        // GET: ConferenceCalls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConferenceCalls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConferenceCallID,ConferenceCallTitle,ConferenceCallDate,ConferenceCallTranscript")] ConferenceCall conferenceCall)
        {
            if (ModelState.IsValid)
            {
                db.ConferenceCalls.Add(conferenceCall);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conferenceCall);
        }

        // GET: ConferenceCalls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceCall conferenceCall = db.ConferenceCalls.Find(id);
            if (conferenceCall == null)
            {
                return HttpNotFound();
            }
            return View(conferenceCall);
        }

        // POST: ConferenceCalls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConferenceCallID,ConferenceCallTitle,ConferenceCallDate,ConferenceCallTranscript")] ConferenceCall conferenceCall)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conferenceCall).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conferenceCall);
        }

        // GET: ConferenceCalls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceCall conferenceCall = db.ConferenceCalls.Find(id);
            if (conferenceCall == null)
            {
                return HttpNotFound();
            }
            return View(conferenceCall);
        }

        // POST: ConferenceCalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConferenceCall conferenceCall = db.ConferenceCalls.Find(id);
            db.ConferenceCalls.Remove(conferenceCall);
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
