using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camraod.Controllers
{
    public class CamrodController : Controller
    {
        // GET: Camrod
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Accueil()
        {
            return View("Accueil");
        }
        public ActionResult Login()
        {
            return View("Login");
        }
        public ActionResult Contact()
        {
            return View("Contact");
        }
        public ActionResult About()
        {
            return View("About");
        }
        public ActionResult Inscription()
        {
            return View("Inscription");
        }
       
    }
}