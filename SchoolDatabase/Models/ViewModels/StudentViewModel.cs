using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolDatabase.Models.Database;
namespace SchoolDatabase.Models.ViewModels
{
    public class StudentViewModel //: Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CourseId { get; set; }
        public ICollection<Course> courses { get; set; }
    }
}