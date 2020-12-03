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
    public class CHITIETHDsController : Controller
    {
        private DBConnect db = new DBConnect();

        // GET: CHITIETHDs
        public ActionResult Index()
        {
            var cHITIETHDs = db.CHITIETHDs.Include(c => c.HOADON).Include(c => c.SANPHAM);
            return View(cHITIETHDs.ToList());
        }

        // GET: CHITIETHDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETHD cHITIETHD = db.CHITIETHDs.Find(id);
            if (cHITIETHD == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETHD);
        }

        // GET: CHITIETHDs/Create
        public ActionResult Create()
        {
            ViewBag.HOADON_MaHD = new SelectList(db.HOADONs, "MaHD", "NHANVIEN_MaNV");
            ViewBag.SANPHAM_MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP");
            return View();
        }

        // POST: CHITIETHDs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,HOADON_MaHD,SANPHAM_MaSP,SoLuong,DonGia,GiamGia,ThanhTien")] CHITIETHD cHITIETHD)
        {
            if (ModelState.IsValid)
            {
                db.CHITIETHDs.Add(cHITIETHD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HOADON_MaHD = new SelectList(db.HOADONs, "MaHD", "NHANVIEN_MaNV", cHITIETHD.HOADON_MaHD);
            ViewBag.SANPHAM_MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP", cHITIETHD.SANPHAM_MaSP);
            return View(cHITIETHD);
        }

        // GET: CHITIETHDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETHD cHITIETHD = db.CHITIETHDs.Find(id);
            if (cHITIETHD == null)
            {
                return HttpNotFound();
            }
            ViewBag.HOADON_MaHD = new SelectList(db.HOADONs, "MaHD", "NHANVIEN_MaNV", cHITIETHD.HOADON_MaHD);
            ViewBag.SANPHAM_MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP", cHITIETHD.SANPHAM_MaSP);
            return View(cHITIETHD);
        }

        // POST: CHITIETHDs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,HOADON_MaHD,SANPHAM_MaSP,SoLuong,DonGia,GiamGia,ThanhTien")] CHITIETHD cHITIETHD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHITIETHD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HOADON_MaHD = new SelectList(db.HOADONs, "MaHD", "NHANVIEN_MaNV", cHITIETHD.HOADON_MaHD);
            ViewBag.SANPHAM_MaSP = new SelectList(db.SANPHAMs, "MaSP", "TenSP", cHITIETHD.SANPHAM_MaSP);
            return View(cHITIETHD);
        }

        // GET: CHITIETHDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETHD cHITIETHD = db.CHITIETHDs.Find(id);
            if (cHITIETHD == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETHD);
        }

        // POST: CHITIETHDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CHITIETHD cHITIETHD = db.CHITIETHDs.Find(id);
            db.CHITIETHDs.Remove(cHITIETHD);
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
