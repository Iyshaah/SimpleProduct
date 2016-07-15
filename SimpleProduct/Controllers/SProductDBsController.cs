using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SimpleProduct.Models;

namespace SimpleProduct.Controllers
{
    public class SProductDBsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SProductDBs
        public ActionResult Index()
        {
            return View(db.SProductDBs.ToList());
        }

        // GET: SProductDBs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SProductDB sProductDB = db.SProductDBs.Find(id);
            if (sProductDB == null)
            {
                return HttpNotFound();
            }
            return View(sProductDB);
        }

        // GET: SProductDBs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SProductDBs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,make,model,year,unitPrice,NumberInStock")] SProductDB sProductDB)
        {
            if (ModelState.IsValid)
            {
                db.SProductDBs.Add(sProductDB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sProductDB);
        }

        // GET: SProductDBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SProductDB sProductDB = db.SProductDBs.Find(id);
            if (sProductDB == null)
            {
                return HttpNotFound();
            }
            return View(sProductDB);
        }

        // POST: SProductDBs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,make,model,year,unitPrice,NumberInStock")] SProductDB sProductDB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sProductDB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sProductDB);
        }

        // GET: SProductDBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SProductDB sProductDB = db.SProductDBs.Find(id);
            if (sProductDB == null)
            {
                return HttpNotFound();
            }
            return View(sProductDB);
        }

        // POST: SProductDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SProductDB sProductDB = db.SProductDBs.Find(id);
            db.SProductDBs.Remove(sProductDB);
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
