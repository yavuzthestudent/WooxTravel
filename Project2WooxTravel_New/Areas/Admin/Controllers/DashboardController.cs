using Project2WooxTravel_New.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        TravelContext context=new TravelContext();
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            var adminCount=context.Admins.ToList().Count();
            ViewBag.AdminCount = adminCount;

            var categoryCount = context.Categories.ToList().Count();
            ViewBag.CategoryCount = categoryCount;

            var destinationCount = context.Destinations.ToList().Count();
            ViewBag.DestinationCount = destinationCount;

            var destinationCapacitySum=context.Destinations.Sum(x => x.Capacity);
            ViewBag.DestinationCapacitySum = destinationCapacitySum;

            var distinctCountryCount=context.Destinations.Select(x=>x.Country).Distinct().Count();
            ViewBag.DistinctCountryCount = distinctCountryCount;

            var reservationCount=context.Reservations.ToList().Count();
            ViewBag.ReservationCount = reservationCount;

            var messsageCount=context.Messages.ToList().Count();
            ViewBag.MesssageCount = messsageCount;

            var peopleCount=context.Reservations.Sum(x=>x.PersonCount);
            ViewBag.PeopleCount = peopleCount;

            var averagePeople = peopleCount / reservationCount;
            ViewBag.AveragePeople = averagePeople;

            var averageMessage= messsageCount/adminCount;
            ViewBag.AverageMessage = averageMessage;

            var dayNightgreaterfive = context.Destinations.Where(x => x.DayNight > 5).Count();
            ViewBag.DayNightgreaterfive= dayNightgreaterfive;

            var dayNightlessfive = destinationCount - dayNightgreaterfive;
            ViewBag.DayNightlessfive= dayNightlessfive;

            return View();
        }
    }
}