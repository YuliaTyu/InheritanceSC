﻿using System;
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
            Human human = new Human("Swarc", "Arnold", 78);
            Console.WriteLine(human);

            Student student = new Student("Colombo", "Franco", 91, "HeavyMetall", "LA", 98, 100);
            Console.WriteLine(student);
        }
    }
}
