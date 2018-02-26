using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class LargestArraySum
    {
        public List<int> Run(IList<NumberArray> input)
        {
            var result = new List<int>();

            //TODO: Find the array with the largest sum of numbers
            //TODO: Initialise data with InitialiseWithNegativeNumbers and assert it works

            var sum = 0;
            var largest = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sum += input[i].Numbers[j];
                }

                if (sum > largest)
                {
                    largest = sum;
                    result.Add(largest);
                }

            }

            Console.WriteLine(largest);
            return result;
        }

        public List<int> Run(IList<NumberArrayNeg> input)
        {
            var resultNeg = new List<int>();

            var sumNeg = 0;
            var largestNeg = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sumNeg = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sumNeg += input[i].Numbers[j];
                }

                if (sumNeg > largestNeg || i == 0)
                {
                    largestNeg = sumNeg;
                    resultNeg.Add(largestNeg);
                }
            }

            Console.WriteLine(largestNeg);
            return resultNeg;
        }
    }
}
