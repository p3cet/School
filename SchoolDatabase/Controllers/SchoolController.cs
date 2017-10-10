using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolDatabase.Models.Database;
using SchoolDatabase.Controllers.Database;
using System.Data.Entity;

namespace SchoolDatabase.Controllers
{
    public class SchoolController : Controller
    {

        private SchoolDatabaseContext Dbc = new SchoolDatabaseContext();
        // GET: School
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
        public ActionResult Add(School school)
        {
            if (ModelState.IsValid)
            {
                Dbc.School.Add(school);
                Dbc.SaveChanges();
            }

            return RedirectToAction("ShowList");
        }

        public ActionResult ShowList()
        {
            return View(Dbc.School.ToList());
        }

        public String Details(int id)
        {
            //School school = Dbc.School.Find(id);
            //if (school == null)
            //     return "HttpNotFound()";
            // return View(school);*/
            var schools = Dbc.School.Include(p => p.Courses).Where(p => p.SchoolId == id);
            string s="";
            foreach (School o in schools)
                s += o.Courses.ToList()[0].Name;
            return s;
            
        }
    }
}