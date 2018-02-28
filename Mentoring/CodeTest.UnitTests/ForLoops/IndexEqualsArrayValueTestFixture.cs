using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Tests.ForLoops;
using NUnit.Framework;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class IndexEqualsArrayValueTestFixture
    {
        [Test]
        public void Run_Invoke_IndexEqualsArray()
        {
            //Arrange
            var input = new[] {7, 45, 5, 98, 4, 90};
            var expected = 4;
            var subject = new IndexEqualsArrayValue();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < expected; i++)
            {
                var num = input[i];
                if (i == num)
                {
                    Assert.AreEqual(expected, result);
                }
            }
        }
    }
}
