using System;

namespace CodeTests.Tests.WhileLoops
{
    public class WhileLoop4 : ICodeTest
    {
        public void Run()
        {
            //TODO: Ask a user for an input and compare it against an expected value, if not ask again, ask a maximum of 5 times before quitting

            //TODO Implement using both && and ||

            var expected = 564;
            var length = 1;

            Console.Write("Input the 3 digit code: ");
            var answer = Convert.ToInt32(Console.ReadLine());

            while (expected != answer && length < 5)
            {
                Console.Write("Nope, try again: ");
                answer = Convert.ToInt32(Console.ReadLine());
                length++;
            }
            //adding this bit for fun
            if (expected != answer)
            {
                Console.WriteLine("What a loser!");
            }
            else
            {
                Console.WriteLine("Correct, you're a star!");
            }
        }
    }
}
