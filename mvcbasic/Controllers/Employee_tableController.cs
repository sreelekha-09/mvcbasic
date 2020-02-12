using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvcbasic.Models;

namespace mvcbasic.Controllers
{
    public class Employee_tableController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();

        // GET: Employee_table
        public ActionResult Index()
        {
            return View(db.Employee_table.ToList());
        }

        // GET: Employee_table/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_table employee_table = db.Employee_table.Find(id);
            if (employee_table == null)
            {
                return HttpNotFound();
            }
            return View(employee_table);
        }

        // GET: Employee_table/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee_table/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Emp_ID,Emp_Name,Emp_Address")] Employee_table employee_table)
        {
            if (ModelState.IsValid)
            {
                db.Employee_table.Add(employee_table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee_table);
        }

        // GET: Employee_table/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_table employee_table = db.Employee_table.Find(id);
            if (employee_table == null)
            {
                return HttpNotFound();
            }
            return View(employee_table);
        }

        // POST: Employee_table/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Emp_ID,Emp_Name,Emp_Address")] Employee_table employee_table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee_table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee_table);
        }

        // GET: Employee_table/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_table employee_table = db.Employee_table.Find(id);
            if (employee_table == null)
            {
                return HttpNotFound();
            }
            return View(employee_table);
        }

        // POST: Employee_table/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee_table employee_table = db.Employee_table.Find(id);
            db.Employee_table.Remove(employee_table);
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
