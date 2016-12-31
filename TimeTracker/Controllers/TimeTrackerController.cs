using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeTracker.Controllers
{
    public class TimeTrackerController : Controller
    {
        // GET: TimeTracker
        public ActionResult Index()
        {
            return View();
        }
    }
}