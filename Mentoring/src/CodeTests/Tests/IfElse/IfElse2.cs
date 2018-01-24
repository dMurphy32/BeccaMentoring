using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.IfElse
{
    public class IfElse2 : ICodeTest
    {
        public void Run()
        {
            //TODO: Ask a user for 2 number inputs, if the sum of the two numbers is even print the sum, otherwise print 0
            // Use Convert.ToInt32(Console.ReadLine()); to read input as a number

            Console.WriteLine("Input 1st number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var sum = num1 + num2;

            if (sum%2+1 == 1)
            {
                Console.WriteLine(sum);
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
