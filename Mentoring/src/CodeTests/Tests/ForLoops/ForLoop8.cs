using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class OddNumbers
    {
        public List<int> Run(IList<NumberArray> input)
        {
            var result = new List<int>();
            // TODO Print the odd numbers from every array

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    var numSet = input[i].Numbers[j];
                    if (numSet%2==1)
                    {
                        Console.WriteLine(numSet);
                        result.Add(numSet);
                    }
                }

                Console.WriteLine();
            }
            return result;
        }
    }
}
