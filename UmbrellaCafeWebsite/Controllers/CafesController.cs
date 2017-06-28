using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UmbrellaCafeWebsite.Controllers
{
    public class CafesController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Cafes";
            return View ();
        }
    }
}
