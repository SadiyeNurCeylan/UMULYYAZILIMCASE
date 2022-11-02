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
    public class paketController : Controller
    {
        private MvcProjeContext db = new MvcProjeContext();

        // GET: paket
        public ActionResult Index()
        {
            return View(db.paketler.ToList());
        }

        // GET: paket/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            paket paket = db.paketler.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // GET: paket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: paket/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Paket")] paket paket)
        {
            if (ModelState.IsValid)
            {
                db.paketler.Add(paket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paket);
        }

        // GET: paket/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            paket paket = db.paketler.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // POST: paket/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Paket")] paket paket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paket);
        }

        // GET: paket/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            paket paket = db.paketler.Find(id);
            if (paket == null)
            {
                return HttpNotFound();
            }
            return View(paket);
        }

        // POST: paket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            paket paket = db.paketler.Find(id);
            db.paketler.Remove(paket);
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
