using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class SmallestArraySum
    { 
        
        public int Run(IList<NumberArray> input)
        {
            var result = new List<int>();

            //TODO: Find the array with the smallest sum of numbers
            //TODO: Initialise data with InitialiseWithNegativeNumbers and assert it works

            var sum = 0;
            var smallest = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sum += input[i].Numbers[j];
                }

                if (sum < smallest||i == 0)
                {
                    smallest = sum;
                    result.Add(smallest);
                }
            }
            Console.WriteLine(smallest);
            return smallest;
        }

        public int Run(IList<NumberArrayNeg> input)
        {
            var resultNeg = new List<int>();

            var sumNeg = 0;
            var smallestNeg = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sumNeg = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sumNeg += input[i].Numbers[j];
                }

                if (sumNeg < smallestNeg || i == 0)
                {
                    smallestNeg = sumNeg;
                    resultNeg.Add(smallestNeg);
                }
            }
            Console.WriteLine(smallestNeg);
            return smallestNeg;
        }
    }
}
