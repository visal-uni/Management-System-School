using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System_School
{
    internal class University
    {
        List<Building> buildings = new List<Building>();
        List<Classes> classes = new List<Classes>();
        List<Teacher> teachers = new List<Teacher>();
        List<Department> departments = new List<Department>();
        List<Student> students = new List<Student>();
        internal protected void Management()
        {
            while (true)
            {
                Console.WriteLine("==== Select option ====");
                Console.WriteLine("1. Departmen");
                Console.WriteLine("2. Building");
                Console.WriteLine("3. Class");
                Console.WriteLine("4. Teacher");
                Console.WriteLine("5. Student");

                Console.Write("Enter option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1": department(); break;
                    case "2": building(); break;
                    case "3": classes(); break;
                    case "4": teacher(); break;
                    case "5": student(); break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
            }
            void department()
            {

            }
            void building()
            {

            }
            void classes()
            {

            }
            void teacher()
            {

            }
            void student()
            {

            }
        }
    }
}
