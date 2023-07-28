using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext context = new TravelContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        } 
        
        public PartialViewResult PartialHeader()
        {
            var tel=context.CompanyContacts.Select(x => x.Phone).First();
            ViewBag.Tel = tel.ToString();
            return PartialView();
        } 
        public PartialViewResult PartialSlider()
        {
            var values = context.Sliders.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialBooking(Booking booking)
        {
            context.Bookings.Add(booking);
            context.SaveChanges();
            return PartialView();
        }

        public PartialViewResult PartialSpecification()
        {
            List<Specification> specifications = new List<Specification>();
            specifications = context.Specifications.Where(x => x.IsMain==true).ToList();
            ViewBag.Spe = specifications;

            var values = context.Specifications.Where(x=>x.IsMain==false).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCovers()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTeams()
        {
            var values = context.Teams.Take(1).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialClient()
        {
            var values = context.Clients.Take(1).ToList();
            return PartialView(values);
        } 
        public PartialViewResult PartialFooter()
        {
            List<CompanyContact> companies = new List<CompanyContact>();
            companies = context.CompanyContacts.Take(1).ToList();
            ViewBag.Company = companies;
            
            List<ContactSocialMedia> icon = new List<ContactSocialMedia>();
            icon = context.ContactSocialMedias.ToList();
            ViewBag.Icon = icon;
            
            List<Specification> spe = new List<Specification>();
            spe = context.Specifications.Take(6).ToList();
            ViewBag.Spe = spe;


            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}