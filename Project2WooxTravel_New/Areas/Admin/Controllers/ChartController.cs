using Project2WooxTravel_New.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        // GET: Admin/Chart
        TravelContext context = new TravelContext();
        public ActionResult LineChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public ActionResult BarChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public ActionResult MultiLineChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public ActionResult MultiBarChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public ActionResult DonutChart()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
    }
}