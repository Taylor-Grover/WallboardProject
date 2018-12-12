using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WallboardSpecialties.DAL;
using WallboardSpecialties.Models;

namespace WallboardSpecialties.Controllers
{
    public class SubcontractorsController : Controller
    {
        private WallboardContext db = new WallboardContext();

        // GET: Subcontractors
        public ActionResult Index()
        {
            return View(db.Subcontractors.ToList());
        }

        // GET: Subcontractors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subcontractor subcontractor = db.Subcontractors.Find(id);
            if (subcontractor == null)
            {
                return HttpNotFound();
            }
            return View(subcontractor);
        }

        // GET: Subcontractors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subcontractors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubcontractorID,CompanyName,subcontractorPhone,subcontractor_TypeID")] Subcontractor subcontractor)
        {
            if (ModelState.IsValid)
            {
                db.Subcontractors.Add(subcontractor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subcontractor);
        }

        // GET: Subcontractors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subcontractor subcontractor = db.Subcontractors.Find(id);
            if (subcontractor == null)
            {
                return HttpNotFound();
            }
            return View(subcontractor);
        }

        // POST: Subcontractors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubcontractorID,CompanyName,subcontractorPhone,subcontractor_TypeID")] Subcontractor subcontractor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subcontractor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subcontractor);
        }

        // GET: Subcontractors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subcontractor subcontractor = db.Subcontractors.Find(id);
            if (subcontractor == null)
            {
                return HttpNotFound();
            }
            return View(subcontractor);
        }

        // POST: Subcontractors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subcontractor subcontractor = db.Subcontractors.Find(id);
            db.Subcontractors.Remove(subcontractor);
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
