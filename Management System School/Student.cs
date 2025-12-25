using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System_School
{
    internal class Student
    {
        private static int conuter = 0;
        private string StdId;
        private string stdName;
        public string StdName
        {
            get => stdName;
            set => stdName = value ?? throw new ArgumentNullException(nameof(value));
        }
        private int stdAge;
        public int StdAge
        {
            get => stdAge;
            set
            {
                if (value < 18)
                    throw new ArgumentOutOfRangeException(nameof(value));
                StdAge = value;
            }
        }
        private string stdAddress;
        public string StdAddress
        {
            get => stdAddress;
            set => stdAddress = value ?? throw new ArgumentNullException(nameof(value));
        }
        public Student(string StdName, int StdAge, string StdAddress, Department dept)
        {
            StdId = $"ST {++conuter:D3}";
            this.StdName = StdName;
            this.StdAge = StdAge;
            this.StdAddress = StdAddress;
            this.Department = dept;
        }
        public Department Department { get; private set; }
    }
}
