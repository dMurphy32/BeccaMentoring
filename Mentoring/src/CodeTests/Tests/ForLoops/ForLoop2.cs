using System;
using System.Collections.Generic;

namespace CodeTests.Tests.ForLoops
{
    public class SetAllToOdd
    {
        public List<int> Run(int[] input)
        {
            //var array = new[] { 1, 2, 3, 4, 5, 6};

            // TODO: Set all odd numbers to 0

            var result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var num = input[i];
                if (num%2 == 1)
                {
                    Console.WriteLine(0);
                    result.Add(0);
                }
                else
                {
                    Console.WriteLine(num);
                    result.Add(num);
                }
            }
            return result;
        }
    }
}
