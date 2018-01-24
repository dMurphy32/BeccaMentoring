using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.IfElse
{
    public class IfElse3 : ICodeTest
    {
        public void Run()
        {
            //TODO: Ask a user for 2 number inputs, if one of them is even print the sum of the two numbers, otherwise print 0
            // Use Convert.ToInt32(Console.ReadLine()); to read input as a number
            //TODO: Change so both must be even to print the sum

            Console.WriteLine("Input 1st number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 + 1 == 1 || num2 % 2 + 1 == 1)
            {
                Console.WriteLine(num1 + num2);
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
