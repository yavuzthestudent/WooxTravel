using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Project2WooxTravel_New.Context;
using Project2WooxTravel_New.Entities;

namespace Project2WooxTravel_New.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext context=new TravelContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialBanner()
        {
            var values=context.Destinations.OrderByDescending(x => x.DestinationId).Take(4).ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCountry(int p=1)
        {
            var values = context.Destinations.ToList().ToPagedList(p, 3);
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public ActionResult DestinationDetail(int id)
        {
            var value = context.Destinations.Where(x=>x.DestinationId == id).ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult ReservationModal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReservationModal(Reservation reservation)
        {
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return View("Index");
        }

    }
}