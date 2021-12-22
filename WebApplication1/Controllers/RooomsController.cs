using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RooomsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Roooms
        public ActionResult Index()
        {
            return View(db.Roooms.ToList());
        }

        // GET: Roooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roooms roooms = db.Roooms.Find(id);
            if (roooms == null)
            {
                return HttpNotFound();
            }
            return View(roooms);
        }

        // GET: Roooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Room_id,place_in")] Roooms roooms)
        {
            if (ModelState.IsValid)
            {
                db.Roooms.Add(roooms);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roooms);
        }

        // GET: Roooms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roooms roooms = db.Roooms.Find(id);
            if (roooms == null)
            {
                return HttpNotFound();
            }
            return View(roooms);
        }

        // POST: Roooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Room_id,place_in")] Roooms roooms)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roooms).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roooms);
        }

        // GET: Roooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roooms roooms = db.Roooms.Find(id);
            if (roooms == null)
            {
                return HttpNotFound();
            }
            return View(roooms);
        }

        // POST: Roooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Roooms roooms = db.Roooms.Find(id);
            db.Roooms.Remove(roooms);
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
