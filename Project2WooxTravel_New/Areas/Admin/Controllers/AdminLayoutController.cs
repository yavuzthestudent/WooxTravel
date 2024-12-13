using Project2WooxTravel_New.Context;
using Project2WooxTravel_New.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        TravelContext context=new TravelContext();
        DashboardIE dashboardIE = new DashboardIE();
        // GET: Admin/AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            
            dashboardIE.messageIE = context.Messages.OrderByDescending(x => x.MessageID).Take(4).ToList();

            var a = Session["x"];
            var name = context.Admins.Where(x => x.UserName == a).Select(y => y.UserName).FirstOrDefault();
            ViewBag.Name = name;

            dashboardIE.destinationIE=context.Destinations.OrderByDescending(x=>x.DestinationId).Take(4).ToList();

            var email=context.Admins.Where(x => x.UserName == a).Select(y => y.Email).FirstOrDefault();
            ViewBag.Email = email;

            return PartialView(dashboardIE);
        }

        public PartialViewResult PartialFooter() 
        {
            return PartialView();
        }
        
        public PartialViewResult PartialScript() 
        {
            return PartialView();
        }

    }
}