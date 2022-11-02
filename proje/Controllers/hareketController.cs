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
    public class hareketController : Controller
    {
        private MvcProjeContext db = new MvcProjeContext();

        // GET: hareket
        public ActionResult Index()
        {
            return View(db.hareketler.ToList());
        }

        // GET: hareket/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hareket hareket = db.hareketler.Find(id);
            if (hareket == null)
            {
                return HttpNotFound();
            }
            return View(hareket);
        }

        // GET: hareket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hareket/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Hareket")] hareket hareket)
        {
            if (ModelState.IsValid)
            {
                db.hareketler.Add(hareket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hareket);
        }

        // GET: hareket/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hareket hareket = db.hareketler.Find(id);
            if (hareket == null)
            {
                return HttpNotFound();
            }
            return View(hareket);
        }

        // POST: hareket/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Hareket")] hareket hareket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hareket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hareket);
        }

        // GET: hareket/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hareket hareket = db.hareketler.Find(id);
            if (hareket == null)
            {
                return HttpNotFound();
            }
            return View(hareket);
        }

        // POST: hareket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hareket hareket = db.hareketler.Find(id);
            db.hareketler.Remove(hareket);
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
