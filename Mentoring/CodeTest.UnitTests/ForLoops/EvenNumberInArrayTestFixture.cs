using System;
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
        [Test]
        public void Run_Invoke_AllNumbersInListTest()
        {
            //Arrange
            var input = new[] {1, 2, 3};
            var expected = new List<NumberArray>
            {
                
            };
            
            var subject = new EvenNumbersInArray();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 1; i < expected.Count; i++)
            {
                for (int j = 1; j < result.Count; j++)
                {
                    Assert.AreEqual(expected[i], result[i]);
                }
            }
        }
    }
}
