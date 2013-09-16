using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUnitTesting.Models;

namespace MVCUnitTesting.Controllers
{
    public class SalutationController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Salutation/

        public ActionResult Index()
        {
            return View(db.Salutations.ToList());
        }

        //
        // GET: /Salutation/Details/5

        public ActionResult Details(int id = 0)
        {
            Salutation salutation = db.Salutations.Find(id);
            if (salutation == null)
            {
                return HttpNotFound();
            }
            return View(salutation);
        }

        //
        // GET: /Salutation/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Salutation/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Salutation salutation)
        {
            if (ModelState.IsValid)
            {
                db.Salutations.Add(salutation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salutation);
        }

        //
        // GET: /Salutation/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Salutation salutation = db.Salutations.Find(id);
            if (salutation == null)
            {
                return HttpNotFound();
            }
            return View(salutation);
        }

        //
        // POST: /Salutation/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Salutation salutation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salutation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salutation);
        }

        //
        // GET: /Salutation/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Salutation salutation = db.Salutations.Find(id);
            if (salutation == null)
            {
                return HttpNotFound();
            }
            return View(salutation);
        }

        //
        // POST: /Salutation/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Salutation salutation = db.Salutations.Find(id);
            db.Salutations.Remove(salutation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}