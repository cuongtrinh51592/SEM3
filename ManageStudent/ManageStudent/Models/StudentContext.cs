using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManageStudent.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("ManageStudent")
        {

        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}