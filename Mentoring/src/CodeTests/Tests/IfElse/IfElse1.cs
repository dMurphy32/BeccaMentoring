using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.IfElse
{
    public class IfElse1 : ICodeTest
    {
        public void Run()
        {
            //TODO: Ask a user for number input, if it is even print the number, otherwise print 0
            // Use Convert.ToInt32(Console.ReadLine()); to read input as a number

            Console.WriteLine("Input a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            if (num1%2+1 == 1)
            {
                Console.WriteLine(num1);
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
