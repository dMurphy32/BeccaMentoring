using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class EvenNumbersEverySecondArray
    {
        public List<int> Run(IList<NumberArray> input)
        {
            var result = new List<int>();
            // TODO Print the even numbers from every second array

            for (int i = 1; i < input.Count; i = i+2)
            {
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    var numSet = input[i].Numbers[j];
                    if (numSet%2 == 0)
                    {
                        Console.WriteLine(numSet);
                        result.Add(numSet);
                    }
                }
            }
            return result;
        }
    }
}
