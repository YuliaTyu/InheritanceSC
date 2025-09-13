using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(" Swarc", " Arnold", 78);
            Console.WriteLine(human);

            Student student = new Student(" Colombo", " Franco",  91, " HeavyMetall", " LA",  98,  100);
            Console.WriteLine(student);

            Teacher teacher = new Teacher(" Jackson", " Michael", 67, 33);
            Console.WriteLine(teacher);

            Graduate graduate = new Graduate(" Anna", " Carenina", 55, " Photographer", " NYT", 100, 100, " Grafica");
            Console.WriteLine(graduate);
        }
    }
}
