using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KursMıx.Models;

namespace KursMıx.Controllers
{
    public class DepartmenController : Controller
    {
        private KURSDBEntities db = new KURSDBEntities();

        // GET: Departmen
        public ActionResult Index()
        {
            return View(db.Departmen.ToList());
        }

        // GET: Departmen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departman departman = db.Departmen.Find(id);
            if (departman == null)
            {
                return HttpNotFound();
            }
            return View(departman);
        }

        // GET: Departmen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departmen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,DepartmanName,DepartmanCode,DepartmanLevel")] Departman departman)
        {
            if (ModelState.IsValid)
            {
                db.Departmen.Add(departman);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(departman);
        }

        // GET: Departmen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departman departman = db.Departmen.Find(id);
            if (departman == null)
            {
                return HttpNotFound();
            }
            return View(departman);
        }

        // POST: Departmen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,DepartmanName,DepartmanCode,DepartmanLevel")] Departman departman)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departman).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(departman);
        }

        // GET: Departmen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Departman departman = db.Departmen.Find(id);
            if (departman == null)
            {
                return HttpNotFound();
            }
            return View(departman);
        }

        // POST: Departmen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Departman departman = db.Departmen.Find(id);
            db.Departmen.Remove(departman);
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
