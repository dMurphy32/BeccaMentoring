using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;
using CodeTests.Tests.ForLoops;
using NUnit.Framework;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class EvenNumbersEverySecondArrayTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 5, 6, 10, 3 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 66, 14, 5, 19 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> {12, 13, 24, 15 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 724, 53, 44, 16 }
            });

            return result;
        }

        [Test]
        public void Run_Invoke_EvenNumbersEverySecondArray()
        {
            //Arrange
            var input = Initialise();
            var expected = new List<int>
            {
                66,
                14,
                724,
                44,
                16
            };
            var subject = new EvenNumbersEverySecondArray();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 1; i < input.Count; i=i+2)
            {
                if (input[i].Numbers.Count % 2 == 0)
                {
                    for (int j = 0; j < input.Count; j++)
                    {
                        var num = input[i].Numbers[j];
                        if (num % 2 == 0)
                        {
                            Assert.AreEqual(result[i], expected[i]);
                        }
                    }
                }
            }
        }
       
    }
}

