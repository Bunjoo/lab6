using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StudentDataModel;

namespace StudentAPI.DataContext
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}