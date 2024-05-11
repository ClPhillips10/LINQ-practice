using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mainNums = { "robert" , "brooke", "trent", "Becky" , "adam"};

            var people = mainNums.Where(p => p.Length == 5 && p.Contains("e"));
            foreach(var p in people)
            {
                Console.WriteLine(p);
            }

        }
    }
}
