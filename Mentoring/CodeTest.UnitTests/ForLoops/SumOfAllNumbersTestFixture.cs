using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;
using NUnit.Framework;
using NUnit.Framework.Internal;
using CodeTests.Tests.ForLoops;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class SumOfAllNumbersTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray
            {
                Numbers = new List<int> { 1, 2, 45}
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 6, 7, 22 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 11, 12, 456 }
            });

            return result;
        }

        [Test]
        public void Run_Invoke_SumOfAllNumbers()
        {
            //Arrange
            var input = Initialise();
            var expected = new List<int>
            {
            562
            };
            var subject = new SumOfAllNumbers();

            //Act
            var result = subject.Run(input);

            //Assert
            var sum = 0;
            var total = sum + sum + sum;
            for (int i = 0; i < input.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    sum += input[i].Numbers[j];
                }
                total += sum;
                Assert.AreEqual(result, expected);
            }

        }
      
    }
}



