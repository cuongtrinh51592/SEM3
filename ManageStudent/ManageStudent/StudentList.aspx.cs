using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using ManageStudent.Models;

namespace ManageStudent
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Student> GetStudents([QueryString("id")] int? classID)
        {
            var _db = new ManageStudent.Models.StudentContext();
            IQueryable<Student> query = _db.Students;
            if (classID.HasValue && classID > 0)
            {
                query = query.Where(p => p.ClassID == classID);
            }
            return query;
        }
    }
}