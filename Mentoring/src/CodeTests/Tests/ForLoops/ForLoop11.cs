using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.ForLoops
{
    public class IndexEqualsArrayValue
    {
        public int Run(int[] input)
        {
            //TODO: Loop through array and exit it if the loop's index equals the arrays value at that  value (@ 4)

            var result = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                var num = input[i];
                if (i == num)
                {
                    Console.WriteLine($"Index equals array value at {i}");
                    result.Add(i);
                }
            }

            return input.Length;
        }
    }
}
