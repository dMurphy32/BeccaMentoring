using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class NumbersInReverse
    {
        public List<int> Run(IList<NumberArray> input)
        {

            // TODO Iterating through the number array classes in order print the numbers in each object in reverse
            // ie. print the array from obj 1 first in reverse, then from obj2 in reverse
            // 5 4 3 2 1 10 9 8 7 6

            var result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = input[i].Numbers.Count -1; j >= 0; j--)
                {
                    Console.Write("{0}, ", input[i].Numbers[j]);
                    result.Add(input[i].Numbers[j]);
                }
                Console.WriteLine();
            }

            return result;
        }
    }
}
