using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Management_System_School
{
    internal class Building : Department
    {
        private static int count = 0;
        private string Id;
        public Building(string Name) : base(Name) 
        {
            Id = $"BU {++count:D3}";
        }
        List<Classes> classes = new List<Classes>();
    }
}
