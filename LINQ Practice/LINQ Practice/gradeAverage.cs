using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class GradeAverage
    {
        public static IEnumerable<int> Intify(string enteredString)
        {
            //will split string 
            var splitString = enteredString.Split(',');
            //changes string to list of ints
            return splitString.Select(s => System.Convert.ToInt32(s));
        }

        public static double AverageAfterDrop(IEnumerable<int> numbers)
        {
            //takes the list of ints.  Removes lowest and averages
            return ((numbers.Sum() - numbers.Min())/(numbers.Count() -1.0));      
        }

        public static double ClassGrades(List<string> grades)
        {
            return grades.Select(g => AverageAfterDrop(Intify(g))).Average();

        }


        List<string> Grades = new List<String>()
            {
                "80,100,92,89,65",
                "93, 81, 78, 84, 69",
                "73, 88, 83, 99, 64",
                "98, 100, 66, 74, 55"
            };

    }
}
