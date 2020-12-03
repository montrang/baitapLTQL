using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQLWEB2.Models;

namespace LTQLWEB2.Migrations
{
    public class NHOMSPsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: NHOMSPs
        public ActionResult Index()
        {
            return View(db.NHOMSPs.ToList());
        }

        // GET: NHOMSPs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHOMSP nHOMSP = db.NHOMSPs.Find(id);
            if (nHOMSP == null)
            {
                return HttpNotFound();
            }
            return View(nHOMSP);
        }

        // GET: NHOMSPs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NHOMSPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhomSP,TenNhomSP")] NHOMSP nHOMSP)
        {
            if (ModelState.IsValid)
            {
                db.NHOMSPs.Add(nHOMSP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nHOMSP);
        }

        // GET: NHOMSPs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHOMSP nHOMSP = db.NHOMSPs.Find(id);
            if (nHOMSP == null)
            {
                return HttpNotFound();
            }
            return View(nHOMSP);
        }

        // POST: NHOMSPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhomSP,TenNhomSP")] NHOMSP nHOMSP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nHOMSP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nHOMSP);
        }

        // GET: NHOMSPs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHOMSP nHOMSP = db.NHOMSPs.Find(id);
            if (nHOMSP == null)
            {
                return HttpNotFound();
            }
            return View(nHOMSP);
        }

        // POST: NHOMSPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NHOMSP nHOMSP = db.NHOMSPs.Find(id);
            db.NHOMSPs.Remove(nHOMSP);
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
