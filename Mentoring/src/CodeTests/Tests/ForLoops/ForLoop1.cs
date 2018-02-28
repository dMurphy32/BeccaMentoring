using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace CodeTests.Tests.ForLoops
{
    public class MultiplyArrayBy2
    {
        public List<int> Run(int[] input)
        {
            //var array = new[] { 1, 2, 3, 4, 5, 6};

            // TODO: Multiply all the elements in the array by 2

            var result = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                result.Add(input[i] * 2);
            }

            return result;
        }
        
    }
}
