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
    public class teslimatController : Controller
    {
        private MvcProjeContext db = new MvcProjeContext();

        // GET: teslimat
        public ActionResult Index()
        {
            return View(db.teslimatlar.ToList());
        }

        // GET: teslimat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teslimat teslimat = db.teslimatlar.Find(id);
            if (teslimat == null)
            {
                return HttpNotFound();
            }
            return View(teslimat);
        }

        // GET: teslimat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: teslimat/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Teslimat")] teslimat teslimat)
        {
            if (ModelState.IsValid)
            {
                db.teslimatlar.Add(teslimat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teslimat);
        }

        // GET: teslimat/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teslimat teslimat = db.teslimatlar.Find(id);
            if (teslimat == null)
            {
                return HttpNotFound();
            }
            return View(teslimat);
        }

        // POST: teslimat/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Teslimat")] teslimat teslimat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teslimat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teslimat);
        }

        // GET: teslimat/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            teslimat teslimat = db.teslimatlar.Find(id);
            if (teslimat == null)
            {
                return HttpNotFound();
            }
            return View(teslimat);
        }

        // POST: teslimat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            teslimat teslimat = db.teslimatlar.Find(id);
            db.teslimatlar.Remove(teslimat);
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
