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
    public class SmallestArrraySumTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray
            {
                Numbers = new List<int> { 1, 2, 3, 4, 500 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 6, 7, 8, 9, 110 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 11, 12, 13, 14, 33 }
            });

            return result;
        }

        private IList<NumberArrayNeg> InitialiseWithNegativeNumbers()
        {
            var result = new List<NumberArrayNeg>();

            result.Add(new NumberArrayNeg
            {
                Numbers = new List<int> { -1, -2, -3, -4, -25 }
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
        public void Run_Invoke_SmallestArraySum()

        {
            //Arrange
            var input = Initialise();
            var expected = new List<int>
            {
                15
            };
            var subject = new SmallestArraySum();

            //Act
            var result = subject.Run(input);

            //Assert
            var sum = 0;
            var smallest = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sum += input[i].Numbers[j];
                }

                if (sum < smallest)
                {
                    smallest = sum;
                    Assert.AreEqual(expected[i], result[i]);
                }
            }
        }

        [Test]
        public void Run_Invoke_SmallestArraySumNeg()

        {
            //Arrange
            var input = InitialiseWithNegativeNumbers();
            var expected = new List<int>
            {
                -65
            };
            var subject = new SmallestArraySum();

            //Act
            var result = subject.Run(input);

            //Assert
            var sum = 0;
            var smallest = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sum += input[i].Numbers[j];
                }

                if (sum < smallest || i == 0)
                {
                    smallest = sum;
                    Assert.AreEqual(expected[i], result[i]);
                }

            }
        }
    }
}
