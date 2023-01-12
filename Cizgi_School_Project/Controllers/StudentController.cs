using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cizgi_School_Project.Models;

namespace Cizgi_School_Project.Controllers
{
    public class StudentController : Controller
    {
        CizgiSchoolDbEntities db = new CizgiSchoolDbEntities();
        public ActionResult Index()
        {
            var values = db.TblStudent.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(TblStudent p)
        {
            db.TblStudent.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteStudent(int id)
        {
            var values = db.TblStudent.Find(id);
            db.TblStudent.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateStudent(int id)
        {
            var values = db.TblStudent.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateStudent(TblStudent p)
        {
            var values = db.TblStudent.Find(p.StudentID);
            values.Name = p.Name;
            values.Surname = p.Surname;
            values.Mail = p.Mail;
            values.Image = p.Image;
            values.Number = p.Number;
            values.PhoneNumber = p.PhoneNumber;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}