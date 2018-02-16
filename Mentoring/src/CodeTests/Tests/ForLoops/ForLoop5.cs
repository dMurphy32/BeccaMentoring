using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.ForLoops
{
    public class EverySecondNumber
    {
        public List<int> Run(int[] input)
        {
            //var array = new[] { 1, 2, 3, 4, 5, 6 };
            // TODO Print every second number in the array without an if statement, do the same in reverse 

            var result = new List<int>();
            for (int i = 0; i < input.Length; i = i + 2)
            {
                Console.WriteLine(i);
                result.Add(i);
            }

            //for (int i = input.Length; i >= 0; i = i - 2)
            //{
            //    Console.WriteLine(i);
            //    result.Add(i);
            //}

            return result;
        }
    }
}
