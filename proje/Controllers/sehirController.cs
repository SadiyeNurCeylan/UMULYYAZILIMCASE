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
    public class sehirController : Controller
    {
        private MvcProjeContext db = new MvcProjeContext();

        // GET: sehir
        public ActionResult Index()
        {
            return View(db.sehirler.ToList());
        }

        // GET: sehir/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sehir sehir = db.sehirler.Find(id);
            if (sehir == null)
            {
                return HttpNotFound();
            }
            return View(sehir);
        }

        // GET: sehir/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sehir/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Sehiradi,Ulke")] sehir sehir)
        {
            if (ModelState.IsValid)
            {
                db.sehirler.Add(sehir);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sehir);
        }

        // GET: sehir/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sehir sehir = db.sehirler.Find(id);
            if (sehir == null)
            {
                return HttpNotFound();
            }
            return View(sehir);
        }

        // POST: sehir/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Sehiradi,Ulke")] sehir sehir)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sehir).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sehir);
        }

        // GET: sehir/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sehir sehir = db.sehirler.Find(id);
            if (sehir == null)
            {
                return HttpNotFound();
            }
            return View(sehir);
        }

        // POST: sehir/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sehir sehir = db.sehirler.Find(id);
            db.sehirler.Remove(sehir);
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
