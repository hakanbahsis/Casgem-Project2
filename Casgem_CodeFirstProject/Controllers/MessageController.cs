using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class MessageController : Controller
    {
        TravelContext context = new TravelContext();

        // GET: Message
        public ActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
    }
}