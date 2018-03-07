using CodeTests.Models;
using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace CodeTests.Tests.ForLoops
{
    public class SumOfAllNumbers
    {
        public List<int> Run(IList<NumberArray> input)
        {
            var result = new List<int>();
            // TODO Sum up all the numbers across all the arrays
            var sum = 0;
            var total = sum + sum + sum;
            for (int i = 0; i < input.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {

                    sum += input[i].Numbers[j];
                }
                total += sum;
            }
            result.Add(total);
            Console.WriteLine(total);
            return result;
        }
    }
}
