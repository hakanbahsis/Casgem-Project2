using Casgem_CodeFirstProject.DAL.Context;
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
            return PartialView();
        } 
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }
        public PartialViewResult PartialSpecification()
        {
            return PartialView();
        }
        public PartialViewResult PartialCovers()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTeams()
        {
            return PartialView();
        }
        public PartialViewResult PartialClient()
        {
            return PartialView();
        } 
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
    }
}