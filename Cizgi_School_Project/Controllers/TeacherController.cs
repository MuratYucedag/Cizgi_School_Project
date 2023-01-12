using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cizgi_School_Project.Models;

namespace Cizgi_School_Project.Controllers
{
    public class TeacherController : Controller
    {
        CizgiSchoolDbEntities db = new CizgiSchoolDbEntities();
        public ActionResult Index()
        {
            var values = db.TblTeacher.ToList();
            return View(values);
        }
    }
}