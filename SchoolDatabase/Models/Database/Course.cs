using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SchoolDatabase.Models.Database
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        [ForeignKey("School")]
        public int SchoolId { get; set; }

        public School School { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}