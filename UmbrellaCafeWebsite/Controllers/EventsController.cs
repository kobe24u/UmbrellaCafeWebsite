using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UmbrellaCafeWebsite.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

		public ActionResult Volunteers()
		{
			return View();
		}

		public ActionResult Children()
		{
			return View();
		}

		public ActionResult Music()
		{
			return View();
		}

		public ActionResult ProfessionalEducation()
		{
			return View();
		}

		public ActionResult CommunityInformation()
		{
			return View();
		}

		public ActionResult InformationNights()
		{
			return View();
		}
    }
}
