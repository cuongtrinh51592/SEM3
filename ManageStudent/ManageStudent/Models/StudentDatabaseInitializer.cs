using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManageStudent.Models
{
    public class StudentDatabaseInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            GetClasses().ForEach(c => context.Classes.Add(c));
            GetStudents().ForEach(s => context.Students.Add(s));
        }

        private static List<Class> GetClasses()
        {
            var classes = new List<Class>
            {
                new Class
                {
                    ClassID = 1,
                    ClassName = "T1904E"
                },
                new Class
                {
                    ClassID = 2,
                    ClassName = "T1906E"
                },
                new Class
                {
                    ClassID = 3,
                    ClassName = "T1907E"
                },
            };
            return classes;
        }

        private static List<Student> GetStudents()
        {
            var students = new List<Student>
            {
                new Student
                {
                    StudentID = 1,
                    StudentName = "Trinh Cao Cuong",
                    Birthday = "05/01/1992",
                    ImagePath="carconvert.png",
                    ClassID = 1
                },
                new Student
                {
                    StudentID = 2,
                    StudentName = "Bui Tuan Anh",
                    Birthday = "05/11/1994",
                    ImagePath="carearly.png",
                    ClassID = 2
                },
                new Student
                {
                    StudentID = 3,
                    StudentName = "Nguyen Thanh",
                    Birthday = "25/10/1993",
                    ImagePath="carfast.png",
                    ClassID = 3
                }
            };
            return students;
        }
    }
}