using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDatabase.Models.Database
{
    public class School
    {
        public int SchoolId { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}