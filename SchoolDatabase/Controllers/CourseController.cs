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
    public class CourseController : Controller
    {
        private SchoolDatabaseContext Dbc = new SchoolDatabaseContext();
        
        // GET: Course
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
        public String Add(Course course)
        {
            if(ModelState.IsValid)
            {
                Dbc.Course.Add(course);
                Dbc.SaveChanges();
            }
            return "Course added to database: " + course.CourseId+", "+course.Name;
        }

        public ActionResult ShowList()
        {
            return View(Dbc.Course.ToList());
        }

        public ActionResult StudentList(int id)
        {
            var course = Dbc.Course.Include(p => p.Students).Where(p => p.CourseId == id).Single();
            return View(course);
        }
    }
}