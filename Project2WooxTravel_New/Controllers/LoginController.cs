﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Project2WooxTravel_New.Context;
using Project2WooxTravel_New.Entities;

namespace Project2WooxTravel_New.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        TravelContext context=new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values=context.Admins.FirstOrDefault(x=>x.UserName==admin.UserName && x.Password==admin.Password);

            if (values != null) 
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["x"] = values.UserName;
                return RedirectToAction("Index","Profile", new { area="Admin" });
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Login");
        }
    }
}