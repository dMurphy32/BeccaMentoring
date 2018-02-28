using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;
using CodeTests.Tests.ForLoops;
using NUnit.Framework;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class LargestArraySumTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray
            {
                Numbers = new List<int> {1, 2, 3, 4, 5}
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> {6, 7, 8, 9, 110}
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> {11, 12, 13, 14, 33}
            });

            return result;
        }

        private IList<NumberArrayNeg> InitialiseWithNegativeNumbers()
        {
            var result = new List<NumberArrayNeg>();

            result.Add(new NumberArrayNeg
            {
                Numbers = new List<int> { -1, -2, -3, -4, -5 }
            });
            result.Add(new NumberArrayNeg
            {
                Numbers = new List<int> { -6, -7, -8, -9, -10 }
            });
            result.Add(new NumberArrayNeg
            {
                Numbers = new List<int> { -11, -12, -13, -14, -15 }
            });

            return result;
        }

        [Test]
        public void Run_Invoke_LargestArraySum()

        {
            //Arrange
            var input = Initialise();
            var expected = 140;
            var subject = new LargestArraySum();

            //Act
            var result = subject.Run(input);

            //Assert
            var sum = 0;
            var largest = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sum += input[i].Numbers[j];
                }

                if (sum < largest)
                {
                    largest = sum;
                   Assert.AreEqual(expected, result);
                }
            }
        }

        [Test]
        public void Run_Invoke_LargestArraySumNeg()

        {
            //Arrange
            var input = InitialiseWithNegativeNumbers();
            var expected = -15;
            var subject = new LargestArraySum();

            //Act
            var result = subject.Run(input);

            //Assert
            var sum = 0;
            var largest = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sum += input[i].Numbers[j];
                }

                if (sum < largest||i == 0)
                {
                    largest = sum;
                    Assert.AreEqual(expected, result);
                }
            }
        }
    }
}
