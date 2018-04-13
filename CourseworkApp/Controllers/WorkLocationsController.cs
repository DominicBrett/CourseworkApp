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
    public class WorkLocationsController : Controller
    {
        private AppDB db = new AppDB();

        // GET: WorkLocations
        public ActionResult Index()
        {
            return View(db.WorkLocations.ToList());
        }

        // GET: WorkLocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkLocation workLocation = db.WorkLocations.Find(id);
            if (workLocation == null)
            {
                return HttpNotFound();
            }
            return View(workLocation);
        }

        // GET: WorkLocations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkLocationID,WorkLocationName,AddressLine1,AddressLine2,City,County,PostCode")] WorkLocation workLocation)
        {
            if (ModelState.IsValid)
            {
                db.WorkLocations.Add(workLocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workLocation);
        }

        // GET: WorkLocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkLocation workLocation = db.WorkLocations.Find(id);
            if (workLocation == null)
            {
                return HttpNotFound();
            }
            return View(workLocation);
        }

        // POST: WorkLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkLocationID,WorkLocationName,AddressLine1,AddressLine2,City,County,PostCode")] WorkLocation workLocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workLocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workLocation);
        }

        // GET: WorkLocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkLocation workLocation = db.WorkLocations.Find(id);
            if (workLocation == null)
            {
                return HttpNotFound();
            }
            return View(workLocation);
        }

        // POST: WorkLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkLocation workLocation = db.WorkLocations.Find(id);
            db.WorkLocations.Remove(workLocation);
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
