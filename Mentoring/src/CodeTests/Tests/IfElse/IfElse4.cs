using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.IfElse
{
    public class IfElse4 : ICodeTest
    {
        public void Run()
        {
            //TODO: Ask a user for 2 number inputs, if the first one is even print it and return, else if the second input is even print that, otherwise print 0


            Console.WriteLine("Input 1st number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 + 1 == 1)
            {
                Console.WriteLine(num1);
            }

            else if (num2 % 2 + 1 == 1)
            {
                Console.WriteLine(num2);
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
