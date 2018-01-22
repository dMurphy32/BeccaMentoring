using System;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop1 : ICodeTest
    {
        public void Run()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6};

            // TODO: Multiply all the elements in the array by 2

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]*2);
            }

        }
    }
}
