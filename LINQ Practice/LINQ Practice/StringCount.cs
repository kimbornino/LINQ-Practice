using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class StringCount
    {
        public static string GetStringCount(string stringOfLetters)
        {

            stringOfLetters = stringOfLetters.ToUpper();
            var sortedLetters = String.Concat(stringOfLetters.OrderBy(c => c).Distinct());

            var finishedString = "";

            foreach (var letter in sortedLetters)
            {
                var letterCount = stringOfLetters.Count(c => c == letter);
                finishedString += letter;
                finishedString += letterCount;
            }

            return finishedString;
        }
    }
}
