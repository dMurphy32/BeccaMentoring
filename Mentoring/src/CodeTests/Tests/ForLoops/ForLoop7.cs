using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class IteratingReverseNumbers
    {
        public List<int> Run(IList<NumberArray> input)
        {
            var result = new List<int>();
            // TODO Iterating through the number array classes in reverse order print the numbers in each object in order 
            // ie. print the array from obj 3 first in order, then from obj 2 in order
            // 11 12 13 14 15 6 7 8 9 10

            for (int i = input.Count-1; i >= 0; i--)
            {
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    result.Add(input[i].Numbers[j]);
                }
            }
            return result;
        }
    }
}
