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
    public class TimeLogsController : Controller
    {
        private WallboardContext db = new WallboardContext();

        // GET: TimeLogs
        public ActionResult Index()
        {
            var timeLogs = db.TimeLogs.Include(t => t.Job_Type).Include(t => t.Project).Include(t => t.Subcontractor);
            return View(timeLogs.ToList());
        }

        // GET: TimeLogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeLog timeLog = db.TimeLogs.Find(id);
            if (timeLog == null)
            {
                return HttpNotFound();
            }
            return View(timeLog);
        }

        // GET: TimeLogs/Create
        public ActionResult Create(string lname, string phone)
        {
            //passes the parameters from the tempemployee to create THEIR instance in the timelog
            ViewBag.lname = lname;
            ViewBag.phone = phone;
            ViewBag.Job_TypeID = new SelectList(db.Job_Type, "Job_TypeID", "Description");
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "Description");
            ViewBag.SubcontractorID = new SelectList(db.Subcontractors, "SubcontractorID", "CompanyName");
            return View();
        }



        // POST: TimeLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LogID,HoursWorked,ProjectID,Job_TypeID,SubcontractorID")] TimeLog timeLog, string lname, string phone)
        {
            if (ModelState.IsValid)
            {
                
                timeLog.Clock_In = DateTime.Now;
                timeLog.Clock_Out = DateTime.Now;
                timeLog.HoursWorked = 8;
                timeLog.LastName = lname;
                timeLog.PhoneNumber = phone;
                db.TimeLogs.Add(timeLog);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Job_TypeID = new SelectList(db.Job_Type, "Job_TypeID", "Description", timeLog.Job_TypeID);
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "Description", timeLog.ProjectID);
            ViewBag.SubcontractorID = new SelectList(db.Subcontractors, "SubcontractorID", "CompanyName", timeLog.SubcontractorID);
            return View(timeLog);
        }

        // GET: TimeLogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeLog timeLog = db.TimeLogs.Find(id);
            if (timeLog == null)
            {
                return HttpNotFound();
            }
            ViewBag.Job_TypeID = new SelectList(db.Job_Type, "Job_TypeID", "Description", timeLog.Job_TypeID);
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "Description", timeLog.ProjectID);
            ViewBag.SubcontractorID = new SelectList(db.Subcontractors, "SubcontractorID", "CompanyName", timeLog.SubcontractorID);
            return View(timeLog);
        }

        // POST: TimeLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LogID,Clock_In,Clock_Out,HoursWorked,PhoneNumber,LastName,ProjectID,Job_TypeID,SubcontractorID")] TimeLog timeLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Job_TypeID = new SelectList(db.Job_Type, "Job_TypeID", "Description", timeLog.Job_TypeID);
            ViewBag.ProjectID = new SelectList(db.Projects, "ProjectID", "Description", timeLog.ProjectID);
            ViewBag.SubcontractorID = new SelectList(db.Subcontractors, "SubcontractorID", "CompanyName", timeLog.SubcontractorID);
            return View(timeLog);
        }

        // GET: TimeLogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeLog timeLog = db.TimeLogs.Find(id);
            if (timeLog == null)
            {
                return HttpNotFound();
            }
            return View(timeLog);
        }

        // POST: TimeLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeLog timeLog = db.TimeLogs.Find(id);
            db.TimeLogs.Remove(timeLog);
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
