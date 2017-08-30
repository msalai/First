﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication18.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PrikaziKategorije()
        {
            List<string> kategorije = new List<string>();
            kategorije.Add("Auti");
            kategorije.Add("Namještaj");
            kategorije.Add("Nekretnine");
            kategorije.Add("Tehnika");

            return PartialView(kategorije);
        }
    }
}