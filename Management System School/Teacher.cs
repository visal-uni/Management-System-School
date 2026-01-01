using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System_School
{
    internal class Teacher : Student
    {
        private static int count = 0;
        private string Id;
        public Teacher(string Name, int Age, string Address, Department dept) : base(Name, Age, Address, dept)
        {
            Id = $"TC {++count:D3}";
        }
        public override Department Department { get; set; }
    }
}
