﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kaylan.Porperty.Web.Controllers
{
    public class PropertyTypeController : Controller
    {
        // GET: PropertyType
        public ActionResult CreatePropertyType()
        {
            return View();
        }

        public ActionResult CreatePropertyTypeDetails()
        {
            return View();
        }
    }
}