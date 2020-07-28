using QualityTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Controller
{
    class StudentController : Student
    {
        List<Student> lsStudents = new List<Student>();
        public void PrintListStudent(List<Student> students)
        {
           
            
                Console.WriteLine("RollNumber : {0}", RollNumber);
                Console.WriteLine("FullName : {0}", FullName);
                Console.WriteLine("Birthday : {0}", Birthday);
                Console.WriteLine("Email : {0}", Email);
                Console.WriteLine("Phone : {0}", Phone);
                Console.WriteLine("Create at : {0}", CreatedAt);
                Console.WriteLine("Status : {0}", Status);
                       
        }

        public void CreateStudent()
        {
            Console.Write("Roll Number : ");
            RollNumber = Console.ReadLine();
            Console.Write("FullName : ");
            FullName = Console.ReadLine();
            Console.Write("Birthday : ");
            Birthday = DateTime.Parse(Console.ReadLine());
            Console.Write("Email : ");
            Email = Console.ReadLine();
            Console.Write("Phone : ");
            Phone = Console.ReadLine();
            Console.Write("Created at : ");
            CreatedAt = DateTime.Parse(Console.ReadLine());
            Console.Write("Status ACTIVE(1) / DEACTIVE (0): ");
            Status = (StudentStatus)byte.Parse(Console.ReadLine());
           
        }
    }
}
