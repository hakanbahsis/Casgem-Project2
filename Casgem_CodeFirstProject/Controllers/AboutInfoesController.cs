using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutInfoesController : Controller
    {
        private TravelContext db = new TravelContext();

        // GET: AboutInfoes
        public ActionResult Index()
        {
            var count = db.AboutInfos.Count();
            ViewBag.Count = count;
            return View(db.AboutInfos.ToList());
        }

        // GET: AboutInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutInfo aboutInfo = db.AboutInfos.Find(id);
            if (aboutInfo == null)
            {
                return HttpNotFound();
            }
            return View(aboutInfo);
        }

        // GET: AboutInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AboutInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,SubDescription,ImageUrl,Status")] AboutInfo aboutInfo)
        {
            if (ModelState.IsValid)
            {
                db.AboutInfos.Add(aboutInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutInfo);
        }

        // GET: AboutInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutInfo aboutInfo = db.AboutInfos.Find(id);
            if (aboutInfo == null)
            {
                return HttpNotFound();
            }
            return View(aboutInfo);
        }

        // POST: AboutInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,SubDescription,ImageUrl,Status")] AboutInfo aboutInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutInfo);
        }

        // GET: AboutInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutInfo aboutInfo = db.AboutInfos.Find(id);
            if (aboutInfo == null)
            {
                return HttpNotFound();
            }
            return View(aboutInfo);
        }

        // POST: AboutInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutInfo aboutInfo = db.AboutInfos.Find(id);
            db.AboutInfos.Remove(aboutInfo);
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
