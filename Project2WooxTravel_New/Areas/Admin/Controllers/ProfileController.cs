using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel_New.Context;
using Project2WooxTravel_New.Entities;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{ 
    [Authorize]
    public class ProfileController : Controller
    {
        TravelContext context=new TravelContext();
       
        // GET: Admin/Profile
        public ActionResult Index()
        {
            var a = Session["x"];
            var values=context.Admins.Where(x=>x.UserName==a).FirstOrDefault();
            return View(values);
        }
    }
}