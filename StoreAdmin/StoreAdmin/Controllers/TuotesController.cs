using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StoreAdmin;

namespace StoreAdmin.Controllers
{
    public class TuotesController : Controller
    {
        private KankaKeidasEntities db = new KankaKeidasEntities();

        // GET: Tuotes
        public ActionResult Index()
        {
            return View(db.Tuote.ToList());
        }

        // GET: Tuotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuote.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // GET: Tuotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tuotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TuoteID,Nimi,Hinta,Veroprosentti")] Tuote tuote)
        {
            if (ModelState.IsValid)
            {
                db.Tuote.Add(tuote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tuote);
        }

        // GET: Tuotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuote.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // POST: Tuotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TuoteID,Nimi,Hinta,Veroprosentti")] Tuote tuote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tuote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tuote);
        }

        // GET: Tuotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuote tuote = db.Tuote.Find(id);
            if (tuote == null)
            {
                return HttpNotFound();
            }
            return View(tuote);
        }

        // POST: Tuotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tuote tuote = db.Tuote.Find(id);
            db.Tuote.Remove(tuote);
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
