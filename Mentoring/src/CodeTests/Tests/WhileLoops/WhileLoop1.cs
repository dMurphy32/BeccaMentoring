using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.WhileLoops
{
    public class WhileLoop1 : ICodeTest
    {
        public void Run()
        {
            var expected = "password";

            //TODO: Ask a user for input and while the input is not equal to expected re-ask for the input
            //TODO: Try implementing as a do while

            //TODO: Implement while loop correctly but with the assertion '==' instead of '!='


            //while loop
            //Console.Write("Input password: ");
            //var input = Console.ReadLine();

            //while (expected != input)
            //{
            //    Console.Write("Input password (again): ");
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine("Correct");

            ////do while loop
            //string input2 = null;
            //do
            //{
            //    Console.Write("Input password: ");
            //    input2 = Console.ReadLine();
            //} while (expected != input2);

            //Console.WriteLine("Correct");

            //while loop with '==' instead of '!='

            Console.Write("Input password: ");
            var input = Console.ReadLine();

            while (!(expected == input))
            {
                Console.Write("Input password (again): ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Correct!");
        }
    }
}
