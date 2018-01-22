using System;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop2 : ICodeTest
    {
        public void Run()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6};

            // TODO: Set all odd numbers to 0

            for (int i = 0; i < array.Length; i++)
            {
                var num = array[i];
                if (num%2 == 1)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
