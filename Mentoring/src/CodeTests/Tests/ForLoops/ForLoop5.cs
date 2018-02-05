using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop5 : ICodeTest
    {
        public void Run()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6 };
            // TODO Print every second number in the array without an if statement, do the same in reverse 

            for (int i = 0; i <= array.Length; i = i + 2)
            {
                Console.WriteLine(i);
            }

            for (int i = array.Length; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
