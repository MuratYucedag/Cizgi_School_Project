using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cizgi_School_Project.Models;

namespace Cizgi_School_Project.Controllers
{
    public class WidgetController : Controller
    {
        CizgiSchoolDbEntities db = new CizgiSchoolDbEntities();
        public ActionResult Index()
        {
            ViewBag.v1 = 964;
            ViewBag.v2 = 50;
            ViewBag.v3 = 15;
            ViewBag.v4 = 84.36;
            return View();
        }
    }
}