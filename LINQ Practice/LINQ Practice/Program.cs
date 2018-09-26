using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(StringCount.GetStringCount("MISSissipPi"));
            

            List<string> Grades = new List<String>()
            {
                "80,100,92,89,65",
                "93, 81, 78, 84, 69",
                "73, 88, 83, 99, 64",
                "98, 100, 66, 74, 55"
            };

            Console.WriteLine(GradeAverage.ClassGrades(Grades));
            Console.ReadLine();
        }
        

    }
}
