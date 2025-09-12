using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        public double Experience { get; set; }

        public Teacher
            (string lastName, string firstName, int age, 
            double experience):base(lastName, firstName, age)
        {
            Experience = experience;
            Console.WriteLine($"TConstructor:\t{GetHashCode().ToString("X")}");
        }
        ~Teacher()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode().ToString("X")}");
        }
        public override string ToString()
        {
            return base.ToString() + $"{Experience} ";
        }
    }
}
