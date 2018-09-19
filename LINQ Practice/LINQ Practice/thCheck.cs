using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class thCheck
    {
        public void CheckForTh()
        {

            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            var thWords = words.Where(t => t.Contains("th"));
            foreach (var word in thWords)
            {
                Console.WriteLine(word);

            }
        }
    }
}
