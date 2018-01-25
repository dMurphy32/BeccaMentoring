using System;
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

            //while loop
            while (true)
            {
                Console.Write("Input password: ");
                var input = Console.ReadLine();

                if (expected == input)
                { break; }
            }

            //do while loop
            do
            {
                Console.Write("Input password: ");
                var input = Console.ReadLine();

                if (expected == input)
                {
                    break;
                }
            } while (true);
        }
    }
}
