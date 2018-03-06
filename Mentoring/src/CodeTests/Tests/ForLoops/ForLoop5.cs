using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class EverySecondNumber
    {
        public List<int> Run(int[] input)
        {
            // TODO Print every second number in the array without an if statement, do the same in reverse 

            var result = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result.Add(input[i]);
                    Console.WriteLine(input[i]);
                }
            }
            return result;
        }
    }
}
