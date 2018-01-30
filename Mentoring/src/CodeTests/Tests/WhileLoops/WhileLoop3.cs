using System;

namespace CodeTests.Tests.WhileLoops
{
    public class WhileLoop3 : ICodeTest
    {
        public void Run()
        {
            var array = new[] { 3, 4, 5, 6, 7, 8 };
            //TODO: Using a while loop Multiply all the elements in the array by 2. Use the array values!

            var num = 1;

            while (num <= array.Length)
            {
                Console.WriteLine(num*2);
                num++;
            }
        }
    }
}
