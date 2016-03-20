using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuetesiegelBewegteSchule.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Uebersicht()
        {
            return View();
        }

        public ActionResult Start()
        {
            return View();
        }

        public ActionResult Unterrichtsqualitaet()
        {
            return View();
        }

        public ActionResult LernUndLebensRaumSchule()
        {
            return View();
        }

        public ActionResult SteuernUndOrganisieren()
        {
            return View();
        }

        public ActionResult AdminLogin()
        {
            return View();
        }

        public ActionResult SchuldatenEingabe()
        {
            return View();
        }

        public ActionResult DatenGespeichert()
        {
            return View();
        }
    }
}