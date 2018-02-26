using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop12 : ICodeTest
    {
        public void Run()
        {
            var data = Initialise();
            var dataNeg = InitialiseWithNegativeNumbers();

            //TODO: Find the array with the largest sum of numbers
            //TODO: Initialise data with InitialiseWithNegativeNumbers and assert it works

            var sum = 0;
            var largest = 0;
            for (int i = 0; i < data.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < data[i].Numbers.Count; j++)
                {
                    sum += data[i].Numbers[j];
                }

                if (sum > largest)
                {
                    largest = sum;
                }
            }

            Console.WriteLine(largest);
            ;



            var sumNeg = 0;
            var largestNeg = 0;
            for (int i = 0; i < dataNeg.Count; i++)
            {
                sumNeg = 0;
                for (int j = 0; j < dataNeg[i].Numbers.Count; j++)
                {
                    sumNeg += dataNeg[i].Numbers[j];
                }

                if (sumNeg > largestNeg || i == 0)
                {
                    largestNeg = sumNeg;
                }
            }

            Console.WriteLine(largestNeg);
            ;
        }

private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray //object 1
            {
                Numbers = new List<int> { 1, 2, 3, 4, 5 }
            });
            result.Add(new NumberArray // object 2
            {
                Numbers = new List<int> { 6, 7, 8, 9, 110 }
            });
            result.Add(new NumberArray //object 3
            {
                Numbers = new List<int> { 11, 12, 13, 14, 15 }
            });

            return result;
        }

        private IList<NumberArray> InitialiseWithNegativeNumbers()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray //object 1
            {
                Numbers = new List<int> { -1, -2, -3, -4, -5 }
            });
            result.Add(new NumberArray // object 2
            {
                Numbers = new List<int> { -6, -7, -8, -9, -10 }
            });
            result.Add(new NumberArray //object 3
            {
                Numbers = new List<int> { -11, -12, -13, -14, -15 }
            });

            return result;
        }
    }
}
