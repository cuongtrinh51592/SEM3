using QualityTest.Controller;
using QualityTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest
{
    class Program : Student
    {
        
        static public int GenerateMenu()
        {
            Console.WriteLine("----------Student Manager----------");
            Console.WriteLine("1. Create Student");
            Console.WriteLine("2. Display Student List");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice : ");
            int choice = Convert.ToInt16(Console.ReadLine());
            return choice;
        }
        static void Main(string[] args)
        {
            List<Student> lsStudents = new List<Student>();
            
            int choice = 0;
            do
            {
                choice = GenerateMenu();
                switch (choice)
                {
                    case 1:
                        StudentController controller = new StudentController();
                        controller.CreateStudent();
                        lsStudents.Add(controller);
                        break;
                    case 2:
                        foreach (StudentController sc in lsStudents)
                        {
                            sc.PrintListStudent(lsStudents);
                        }
                        break;
                    default:
                        break;
                }
            } while (choice != 3);



            Console.ReadLine();

        }
    }
}
