using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ContactController : Controller
    {

        TravelContext context = new TravelContext();

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialBanner() { return PartialView(); }

        [HttpGet]
        public PartialViewResult PartialContact() 
        {
            List<CompanyContact> company = new List<CompanyContact>();
            company = context.CompanyContacts.Take(1).ToList();
            ViewBag.Company = company;

            return PartialView(); 
        }

        [HttpPost]
        public PartialViewResult PartialContact(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            return PartialView();
        }
    }
}