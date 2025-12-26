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
        private string Id;
        private string name;
        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }
        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (value < 18)
                    throw new ArgumentOutOfRangeException(nameof(value));
                age = value;
            }
        }
        private string address;
        public string Address
        {
            get => address;
            set => address = value ?? throw new ArgumentNullException(nameof(value));
        }
        public Student(string Name, int Age, string Address, Department dept)
        {
            Id = $"ST {++conuter:D3}";
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
            this.Department = dept;
        }
        public Department Department { get; private set; }
    }
}
