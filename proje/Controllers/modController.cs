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
    public class modController : Controller
    {
        private MvcProjeContext db = new MvcProjeContext();

        // GET: mod
        public ActionResult Index()
        {
            return View(db.modlar.ToList());
        }

        // GET: mod/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mod mod = db.modlar.Find(id);
            if (mod == null)
            {
                return HttpNotFound();
            }
            return View(mod);
        }

        // GET: mod/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mod/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Mod")] mod mod)
        {
            if (ModelState.IsValid)
            {
                db.modlar.Add(mod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mod);
        }

        // GET: mod/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mod mod = db.modlar.Find(id);
            if (mod == null)
            {
                return HttpNotFound();
            }
            return View(mod);
        }

        // POST: mod/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Mod")] mod mod)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mod);
        }

        // GET: mod/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mod mod = db.modlar.Find(id);
            if (mod == null)
            {
                return HttpNotFound();
            }
            return View(mod);
        }

        // POST: mod/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mod mod = db.modlar.Find(id);
            db.modlar.Remove(mod);
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
