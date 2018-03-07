using CodeTests.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Tests.ForLoops;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class OddNumbersTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray
            {
                Numbers = new List<int> { 21, 12, 14 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 9, 7, 3, }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 10, 42, 13, }
            });

            return result;
        }

        [Test]
        public void Run_Invoke_OddNumbers()

        {
            //Arrange
            var input = Initialise();
            var expected = new List<int>
            {
                21,
                9,
                7,
                3,
                13
            };
            var subject = new OddNumbers();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {

                    if (input[i].Numbers[j] % 2 == 1)
                    {
                        Assert.AreEqual(result, expected);
                    }
                }
            }
        }


    }
}
