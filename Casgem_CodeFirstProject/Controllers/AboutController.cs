using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutController : Controller
    {
        TravelContext context = new TravelContext(); 
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAboutBanner()
        {
            return PartialView();
        }

        public PartialViewResult PartialInfo()
        {
            var values = context.AboutInfos.Take(1).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTeams()
        {
            var values = context.Teams.ToList();
            return PartialView(values);
        }
    }
}