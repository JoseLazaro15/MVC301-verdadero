using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC301.Models;

namespace MVC301.Controllers
{
    public class ventasController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: ventas
        public ActionResult Index()
        {
            var ventas = db.ventas.Include(v => v.productos).Include(v => v.vendedor);
            return View(ventas.ToList());
        }

        // GET: ventas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ventas ventas = db.ventas.Find(id);
            if (ventas == null)
            {
                return HttpNotFound();
            }
            return View(ventas);
        }

        // GET: ventas/Create
        public ActionResult Create()
        {
            ViewBag.ClaveP = new SelectList(db.productos, "ClaveP", "Descripcion");
            ViewBag.IdVendedor = new SelectList(db.vendedor, "IdVendedor", "NombreVendedor");
            return View();
        }

        // POST: ventas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdVenta,IdVendedor,ClaveP,Iva,Total")] ventas ventas)
        {
            if (ModelState.IsValid)
            {
                db.ventas.Add(ventas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClaveP = new SelectList(db.productos, "ClaveP", "Descripcion", ventas.ClaveP);
            ViewBag.IdVendedor = new SelectList(db.vendedor, "IdVendedor", "NombreVendedor", ventas.IdVendedor);
            return View(ventas);
        }

        // GET: ventas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ventas ventas = db.ventas.Find(id);
            if (ventas == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClaveP = new SelectList(db.productos, "ClaveP", "Descripcion", ventas.ClaveP);
            ViewBag.IdVendedor = new SelectList(db.vendedor, "IdVendedor", "NombreVendedor", ventas.IdVendedor);
            return View(ventas);
        }

        // POST: ventas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdVenta,IdVendedor,ClaveP,Iva,Total")] ventas ventas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ventas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClaveP = new SelectList(db.productos, "ClaveP", "Descripcion", ventas.ClaveP);
            ViewBag.IdVendedor = new SelectList(db.vendedor, "IdVendedor", "NombreVendedor", ventas.IdVendedor);
            return View(ventas);
        }

        // GET: ventas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ventas ventas = db.ventas.Find(id);
            if (ventas == null)
            {
                return HttpNotFound();
            }
            return View(ventas);
        }

        // POST: ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ventas ventas = db.ventas.Find(id);
            db.ventas.Remove(ventas);
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
