using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.WhileLoops
{
    public class WhileLoop2 : ICodeTest
    {
        public void Run()
        {
            var expectedStr = "password";
            var expectedInt = 1;

            //TODO: Ask a user for a string input and a number input, while both are not equal to expeced re-ask for the inputs
            // Use Convert.ToInt32(Console.ReadLine()); to read input as a number
            //TODO: What if we only needed one to match?
            //TODO: Try implementing as a do while

            //both need to match
            Console.Write("Input a string: ");
            var strInput = Console.ReadLine();

            Console.Write("Input a number: ");
            var intInput = Convert.ToInt32(Console.ReadLine());

            while (strInput != expectedStr || intInput != expectedInt)
            {
                Console.Write("Input a string: ");
                strInput = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput = Convert.ToInt32(Console.ReadLine());
             }

            //both need to match as a do while loop
            string strInput2 = null;
            var intInput2 = 0;

            do
            {
                Console.Write("Input a string: ");
                strInput2 = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput2 = Convert.ToInt32(Console.ReadLine());
            } while (strInput2 != expectedStr || intInput2 != expectedInt);

            //only 1 needs to match
            Console.Write("Input a string: ");
            var strInput3 = Console.ReadLine();

            Console.Write("Input a number: ");
            var intInput3 = Convert.ToInt32(Console.ReadLine());

            while (strInput3 != expectedStr && intInput3 != expectedInt)
            {
                Console.Write("Input a string: ");
                strInput3 = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput3 = Convert.ToInt32(Console.ReadLine());
            }

           // only 1 needs to match as a do while loop
            string strInput4 = null;
            var intInput4 = 0;

            do
            {
                Console.Write("Input a string: ");
                strInput4 = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput4 = Convert.ToInt32(Console.ReadLine());
            } while (strInput4 != expectedStr && intInput4 != expectedInt);
        }
    }
}
