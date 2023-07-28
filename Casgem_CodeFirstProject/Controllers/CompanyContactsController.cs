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
    public class CompanyContactsController : Controller
    {
        private TravelContext db = new TravelContext();

        // GET: CompanyContacts
        public ActionResult Index()
        {
            var count = db.CompanyContacts.Count();
            ViewBag.Count = count;
            return View(db.CompanyContacts.ToList());
        }

        // GET: CompanyContacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyContact companyContact = db.CompanyContacts.Find(id);
            if (companyContact == null)
            {
                return HttpNotFound();
            }
            return View(companyContact);
        }

        // GET: CompanyContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompanyContacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Address,Phone,Mail")] CompanyContact companyContact)
        {
            if (ModelState.IsValid)
            {
                db.CompanyContacts.Add(companyContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(companyContact);
        }

        // GET: CompanyContacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyContact companyContact = db.CompanyContacts.Find(id);
            if (companyContact == null)
            {
                return HttpNotFound();
            }
            return View(companyContact);
        }

        // POST: CompanyContacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Address,Phone,Mail")] CompanyContact companyContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(companyContact);
        }

        // GET: CompanyContacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyContact companyContact = db.CompanyContacts.Find(id);
            if (companyContact == null)
            {
                return HttpNotFound();
            }
            return View(companyContact);
        }

        // POST: CompanyContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompanyContact companyContact = db.CompanyContacts.Find(id);
            db.CompanyContacts.Remove(companyContact);
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
