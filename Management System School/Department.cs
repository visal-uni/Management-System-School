using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System_School
{
    internal class Department
    {
        private static int counter = 0;
        public string DeptId { get; }
        private string deptName;
        public string DeptName
        {
            get => deptName;
            set => deptName = value ?? throw new ArgumentNullException(nameof(value));
        }
        public Department(string DeptName)
        {
            DeptId = $"DP{++counter:D3}";
            this.DeptName = DeptName ?? throw new ArgumentNullException(nameof(DeptName));
        }
        List<Student> students = new List<Student>();
        List<Professor> professors = new List<Professor>();
    }
}
