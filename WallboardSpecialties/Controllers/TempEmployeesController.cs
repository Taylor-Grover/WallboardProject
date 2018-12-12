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
    public class TempEmployeesController : Controller
    {
        private WallboardContext db = new WallboardContext();

        // GET: TempEmployees
        public ActionResult Index()
        {
            return View(db.TempEmployees.ToList());
        }

        // GET: TempEmployees/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TempEmployee tempEmployee = db.TempEmployees.Find(id);
            if (tempEmployee == null)
            {
                return HttpNotFound();
            }
            return View(tempEmployee);
        }

        // GET: TempEmployees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TempEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PhoneNumber,LastName,FirstName")] TempEmployee tempEmployee)
        {
            if (ModelState.IsValid)
            {
                var currentUser = db.Database.SqlQuery<TempEmployee>("SELECT * " +
                                                           "FROM TempEmployee " +
                                                           "WHERE LastName LIKE '" + tempEmployee.LastName + "' AND " +
                                                           "PhoneNumber LIKE '" + tempEmployee.PhoneNumber + "'");
                if (currentUser.Count() > 0)
                {
                    
                    return RedirectToAction("Create", "TimeLogs", new { lname = tempEmployee.LastName, phone = tempEmployee.PhoneNumber });
                }
                else
                {
                    db.TempEmployees.Add(tempEmployee);
                    db.SaveChanges();
                    return RedirectToAction("Create", "TimeLogs", new { lname = tempEmployee.LastName, phone = tempEmployee.PhoneNumber });
                }
            }

            return View(tempEmployee);
        }

        // GET: TempEmployees/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TempEmployee tempEmployee = db.TempEmployees.Find(id);
            if (tempEmployee == null)
            {
                return HttpNotFound();
            }
            return View(tempEmployee);
        }

        // POST: TempEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PhoneNumber,LastName,FirstName")] TempEmployee tempEmployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tempEmployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tempEmployee);
        }

        // GET: TempEmployees/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TempEmployee tempEmployee = db.TempEmployees.Find(id);
            if (tempEmployee == null)
            {
                return HttpNotFound();
            }
            return View(tempEmployee);
        }

        // POST: TempEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TempEmployee tempEmployee = db.TempEmployees.Find(id);
            db.TempEmployees.Remove(tempEmployee);
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
