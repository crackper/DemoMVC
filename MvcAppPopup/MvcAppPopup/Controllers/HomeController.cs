﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAppPopup.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            ViewBag.Message = "ASP.NET MVC";

            return View();
        }

        public virtual ActionResult About()
        {
            return View();
        }
    }
}
