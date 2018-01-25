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

                //A break to end a while loop should only be used in exceptional circumstances
                //ie. working on an array and some operation in it removes all items in the array (poor example)
                //At the end of every while loop the condition in the while loop is asserted and it only executes if it is true
                //Currently it is always true, but you could move a version of this conition into it instead
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
                //Same as above
            } while (true);
        }
    }
}
