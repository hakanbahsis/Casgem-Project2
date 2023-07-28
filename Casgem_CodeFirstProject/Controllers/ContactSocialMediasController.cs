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
    public class ContactSocialMediasController : Controller
    {
        private TravelContext db = new TravelContext();

        // GET: ContactSocialMedias
        public ActionResult Index()
        {
            return View(db.ContactSocialMedias.ToList());
        }

        // GET: ContactSocialMedias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactSocialMedia contactSocialMedia = db.ContactSocialMedias.Find(id);
            if (contactSocialMedia == null)
            {
                return HttpNotFound();
            }
            return View(contactSocialMedia);
        }

        // GET: ContactSocialMedias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactSocialMedias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Url,Icon,Status")] ContactSocialMedia contactSocialMedia)
        {
            if (ModelState.IsValid)
            {
                db.ContactSocialMedias.Add(contactSocialMedia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactSocialMedia);
        }

        // GET: ContactSocialMedias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactSocialMedia contactSocialMedia = db.ContactSocialMedias.Find(id);
            if (contactSocialMedia == null)
            {
                return HttpNotFound();
            }
            return View(contactSocialMedia);
        }

        // POST: ContactSocialMedias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Url,Icon,Status")] ContactSocialMedia contactSocialMedia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactSocialMedia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactSocialMedia);
        }

        // GET: ContactSocialMedias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactSocialMedia contactSocialMedia = db.ContactSocialMedias.Find(id);
            if (contactSocialMedia == null)
            {
                return HttpNotFound();
            }
            return View(contactSocialMedia);
        }

        // POST: ContactSocialMedias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactSocialMedia contactSocialMedia = db.ContactSocialMedias.Find(id);
            db.ContactSocialMedias.Remove(contactSocialMedia);
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
