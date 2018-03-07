using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;
using NUnit.Framework;
using CodeTests.Tests.ForLoops;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class IteratingReverseNumbersTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray
            {
                Numbers = new List<int> { 7, 9, 3 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 12, 43, 6}
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 15, 2, 78 }
            });
            return result;
        }

        [Test]
        public void Run_Invoke_IteratingReverseNumbers()
        {
            //Arrange
            var input = Initialise();
            var expected = new List<int>
            {
                15,
                2,
                78,
                12,
                43,
                6,
                7,
                9,
                3
            };
            var subject = new IteratingReverseNumbers();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = input.Count-1; i >= 0; i--)
            {
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    Assert.AreEqual(expected, result);
                }
            }
        }

    }
}
