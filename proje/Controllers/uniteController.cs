using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proje.Models.Context;
using proje.Models.Entities;

namespace proje.Controllers
{
    public class uniteController : Controller
    {
        private MvcProjeContext db = new MvcProjeContext();

        // GET: unite
        public ActionResult Index()
        {
            return View(db.uniteler.ToList());
        }

        // GET: unite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unite unite = db.uniteler.Find(id);
            if (unite == null)
            {
                return HttpNotFound();
            }
            return View(unite);
        }

        // GET: unite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: unite/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Unite")] unite unite)
        {
            if (ModelState.IsValid)
            {
                db.uniteler.Add(unite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unite);
        }

        // GET: unite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unite unite = db.uniteler.Find(id);
            if (unite == null)
            {
                return HttpNotFound();
            }
            return View(unite);
        }

        // POST: unite/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Unite")] unite unite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unite);
        }

        // GET: unite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            unite unite = db.uniteler.Find(id);
            if (unite == null)
            {
                return HttpNotFound();
            }
            return View(unite);
        }

        // POST: unite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            unite unite = db.uniteler.Find(id);
            db.uniteler.Remove(unite);
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
