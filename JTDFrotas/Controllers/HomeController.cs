﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JTDFrotas.Controllers
{
    //[Authorize]
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        } 
    }
}