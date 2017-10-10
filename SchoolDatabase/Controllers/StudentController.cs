using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolDatabase.Models.Database;
using SchoolDatabase.Controllers.Database;

namespace SchoolDatabase.Controllers
{
    public class StudentController : Controller
    {
        private SchoolDatabaseContext Dbc = new SchoolDatabaseContext();
        
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                Dbc.Student.Add(student);
                Dbc.SaveChanges();
            }
            return RedirectToAction("ShowList");
        }

        [HttpGet]
        public ActionResult ShowList()
        {
            return View(Dbc.Student.ToList());
        }

        [HttpPost]
        public ActionResult ShowDetails(int id)
        {
            return View(id);
        }
    }
}