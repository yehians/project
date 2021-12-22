using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class IitemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Iitems
        public ActionResult Index()
        {
            return View(db.Iitems.ToList());
        }

        // GET: Iitems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Iitem iitem = db.Iitems.Find(id);
            if (iitem == null)
            {
                return HttpNotFound();
            }
            return View(iitem);
        }

        // GET: Iitems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Iitems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Iitem iitem,HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                string path=Path.Combine(Server.MapPath("~/Images"),upload.FileName);
                upload.SaveAs(path);
                iitem.Image = upload.FileName;
                db.Iitems.Add(iitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iitem);
        }

        // GET: Iitems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Iitem iitem = db.Iitems.Find(id);
            if (iitem == null)
            {
                return HttpNotFound();
            }
            return View(iitem);
        }

        // POST: Iitems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Iitem iitem, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                string path = Path.Combine(Server.MapPath("~/Images"), upload.FileName);
                upload.SaveAs(path);
                iitem.Image = upload.FileName;
                db.Entry(iitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iitem);
        }

        // GET: Iitems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Iitem iitem = db.Iitems.Find(id);
            if (iitem == null)
            {
                return HttpNotFound();
            }
            return View(iitem);
        }

        // POST: Iitems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Iitem iitem = db.Iitems.Find(id);
            db.Iitems.Remove(iitem);
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
