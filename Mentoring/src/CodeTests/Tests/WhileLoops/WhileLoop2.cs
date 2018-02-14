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


            //TODO Implement using both && and ||

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

            //both need to match with &&
            Console.Write("Input a string: ");
            var strInput5 = Console.ReadLine();

            Console.Write("Input a number: ");
            var intInput5 = Convert.ToInt32(Console.ReadLine());

            while (!(strInput5 == expectedStr && intInput5 == expectedInt))
            {
                Console.Write("Input a string: ");
                strInput5 = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput5 = Convert.ToInt32(Console.ReadLine());
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

            //both need to match as a do while loop using &&
            string strInput6 = null;
            var intInput6 = 0;

            do
            {
                Console.Write("Input a string: ");
                strInput6 = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput6 = Convert.ToInt32(Console.ReadLine());
            } while (!(strInput6 == expectedStr && intInput6 == expectedInt));

            //    //only 1 needs to match
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

            //only 1 needs to match using ||
            Console.Write("Input a string: ");
            var strInput7 = Console.ReadLine();

            Console.Write("Input a number: ");
            var intInput7 = Convert.ToInt32(Console.ReadLine());

            while (!(strInput7 == expectedStr || intInput7 == expectedInt))
            {
                Console.Write("Input a string: ");
                strInput7 = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput7 = Convert.ToInt32(Console.ReadLine());
            }


            //   // only 1 needs to match as a do while loop
            string strInput4 = null;
            var intInput4 = 0;

            do
            {
                Console.Write("Input a string: ");
                strInput4 = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput4 = Convert.ToInt32(Console.ReadLine());
            } while (strInput4 != expectedStr && intInput4 != expectedInt);

            // only 1 needs to match as a do while loop using ||
            string strInput8 = null;
            var intInput8 = 0;

            do
            {
                Console.Write("Input a string: ");
                strInput8 = Console.ReadLine();

                Console.Write("Input a number: ");
                intInput8 = Convert.ToInt32(Console.ReadLine());
            } while (!(strInput8 == expectedStr || intInput8 == expectedInt));
        }
    }
}
