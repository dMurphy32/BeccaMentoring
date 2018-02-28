using CodeTests.Models;
using System;
using System.Collections.Generic;

namespace CodeTests.Tests.ForLoops
{
    public class SumOfAllNumbers
    {
        public int Run(IList<NumberArray> input)
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
                    //total += i;
                }
                Console.WriteLine($"The sum of object {i} = {sum}");
                total += sum;
            }
            Console.WriteLine($"total is {total}");
            result.Add(total);

            return total;
        }
    }
}
