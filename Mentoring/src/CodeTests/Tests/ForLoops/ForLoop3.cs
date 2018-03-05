using System;
using System.Collections.Generic;

namespace CodeTests.Tests.ForLoops
{
    public class ReverseArray
    {
        public  List<int> Run(int[] input)
        {

            // TODO: Create new array that is the reverse of the original

            var result = new List<int>();
            for (int i = 0; i > input.Length; i--)
            {
                result.Add(i);
            }

            return result;


        }
    }
}
