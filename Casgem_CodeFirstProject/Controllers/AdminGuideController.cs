using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminGuideController : Controller
    {
        TravelContext context = new TravelContext();
        // GET: AdminGuide
        public ActionResult Index()
        {
            var values = context.Guides.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGuide(Guide guide)
        {
            if (ModelState.IsValid)
            {
                context.Guides.Add(guide);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guide);
        }

        public ActionResult DeleteGuide(int id)
        {
            var values = context.Guides.Find(id);
            context.Guides.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateGuide(int id)
        {
            var values = context.Guides.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateGuide(Guide guide)
        {
            if (ModelState.IsValid)
            {
                var values = context.Guides.Find(guide.GuideId);
                values.GuideName = guide.GuideName;
                values.Title = guide.Title;
                values.ImageUrl = guide.ImageUrl;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guide);
        }
    }
}