using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System_School
{
    internal class Classes : Department
    {
        private static int count = 0;
        private string Id;
        public Classes(string Name) : base(Name) 
        {
            Id = $"CL {++count:D3}";
        }
        List<Teacher> teachers = new List<Teacher>();
        List<Student> students = new List<Student>();
    }
}
