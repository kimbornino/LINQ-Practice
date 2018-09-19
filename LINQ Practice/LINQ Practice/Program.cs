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
            var names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            var noRepeats = names.Distinct();
            foreach (var name in noRepeats)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

        }
    }
}
