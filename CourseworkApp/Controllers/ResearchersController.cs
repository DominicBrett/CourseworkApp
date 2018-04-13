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
    public class ResearchersController : Controller
    {
        private AppDB db = new AppDB();

        // GET: Researchers
        public ActionResult Index()
        {
            return View(db.Researchers.ToList());
        }

        // GET: Researchers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Researcher researcher = db.Researchers.Find(id);
            if (researcher == null)
            {
                return HttpNotFound();
            }
            return View(researcher);
        }

        // GET: Researchers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Researchers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ResearcherID,Name,Gender,DOB,EMail,AddressLine1,AddressLine2,City,County,PostCode,HomePhone,WorkPhone,MobilePhone,Biography,KeyWords,MoreInfo,WorkLocationID")] Researcher researcher)
        {
            if (ModelState.IsValid)
            {
                db.Researchers.Add(researcher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(researcher);
        }

        // GET: Researchers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Researcher researcher = db.Researchers.Find(id);
            if (researcher == null)
            {
                return HttpNotFound();
            }
            return View(researcher);
        }

        // POST: Researchers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ResearcherID,Name,Gender,DOB,EMail,AddressLine1,AddressLine2,City,County,PostCode,HomePhone,WorkPhone,MobilePhone,Biography,KeyWords,MoreInfo,WorkLocationID")] Researcher researcher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(researcher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(researcher);
        }

        // GET: Researchers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Researcher researcher = db.Researchers.Find(id);
            if (researcher == null)
            {
                return HttpNotFound();
            }
            return View(researcher);
        }

        // POST: Researchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Researcher researcher = db.Researchers.Find(id);
            db.Researchers.Remove(researcher);
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
