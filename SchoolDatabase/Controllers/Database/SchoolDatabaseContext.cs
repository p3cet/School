namespace SchoolDatabase.Controllers.Database
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SchoolDatabase.Models.Database;

    public class SchoolDatabaseContext : DbContext
    {
        public SchoolDatabaseContext()
            : base("name=SchoolDatabase")
        {
        }
        public DbSet<School> School { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}