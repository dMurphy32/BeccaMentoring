using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest.UnitTests.ForLoops;
using CodeTests.Models;
using CodeTests.Tests.ForLoops;
using NUnit.Framework;


namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class EvenNumberInArrayTestFixture
    {

        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 5, 6, 10, 3}
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int>{ 66, 14, 5, 19}
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int>{ 11, 12, 13, 14, 15 }
            });

            return result;
          }

        [Test]
        public void Run_Invoke_EvenNumbersInArray()
        {
            //Arrange
            var input = Initialise();
            var expected = new List<int>
            {
                6,
                10,
                66,
                14,
                12,
                14
            };
            var subject = new EvenNumbersInArray();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    if (input[i].Numbers[j] % 2 == 0)
                    {
                        Assert.AreEqual(result[i], expected[i]);
                    }
                }
            }
        }
    }
}

