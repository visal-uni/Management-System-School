using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System_School
{
    internal abstract class Department
    {
        private static int counter = 0;
        public string Id { get; }
        private string name;
        public string DeptName
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }
        public Department(string Name)
        {
            Id = $"DP {++counter:D3}";
            this.name = Name ?? throw new ArgumentNullException(nameof(DeptName));
        }
        List<Student> students = new List<Student>();
        List<Teacher> professors = new List<Teacher>();
    }
}
