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
    public class paraController : Controller
    {
        private MvcProjeContext db = new MvcProjeContext();

        // GET: para
        public ActionResult Index()
        {
            return View(db.paralar.ToList());
        }

        // GET: para/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            para para = db.paralar.Find(id);
            if (para == null)
            {
                return HttpNotFound();
            }
            return View(para);
        }

        // GET: para/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: para/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Para")] para para)
        {
            if (ModelState.IsValid)
            {
                db.paralar.Add(para);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(para);
        }

        // GET: para/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            para para = db.paralar.Find(id);
            if (para == null)
            {
                return HttpNotFound();
            }
            return View(para);
        }

        // POST: para/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Para")] para para)
        {
            if (ModelState.IsValid)
            {
                db.Entry(para).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(para);
        }

        // GET: para/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            para para = db.paralar.Find(id);
            if (para == null)
            {
                return HttpNotFound();
            }
            return View(para);
        }

        // POST: para/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            para para = db.paralar.Find(id);
            db.paralar.Remove(para);
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
