﻿using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel_New
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
