using System;
using System.Collections.Generic;

namespace CodeTests.Tests.ForLoops
{
    public class ReverseArray
    {
        public  List<int> Run(int[] input)
        {
            //var array = new[] { 1, 2, 3, 4, 5, 6 };

            // TODO: Create new array that is the reverse of the original

            var result = new List<int>();

            for (int i = input.Length; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            return result ;
        }
    }
}
