using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Finalmvc.Models;
namespace Finalmvc.Controllers
{
    public class Employee1Controller : Controller
    {
        private empdbEntities db = new empdbEntities();

        // GET: Employee1
        public ActionResult Index()
        {
            return View(db.employees.ToList());
        }

        // GET: Employee1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee1/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                employee emp = new employee();
                emp.empname = collection["empname"];
                emp.email = collection["email"];
                emp.phoneno = collection["phoneno"];
                empdbEntities userRegistrationEntities = new empdbEntities();
                userRegistrationEntities.employees.Add(emp);
                userRegistrationEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee1/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
