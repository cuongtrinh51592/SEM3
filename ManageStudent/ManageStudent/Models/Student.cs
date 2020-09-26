using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageStudent.Models
{
    public class Student
    {
        [ScaffoldColumn(false)]
        public int StudentID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string StudentName { get; set; }

        public string Birthday { get; set; }

        public string ImagePath { get; set; }

        public int? ClassID { get; set; }

        public virtual Class Class { get; set; }
    }
}