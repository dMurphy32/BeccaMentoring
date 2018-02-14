using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeTests.Tests.ForLoops;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class ReverseArrayTestFixture
    {
        [Test]
        public void Run_Invoke_ReturnsReverseArray()
        {
            //Arrange
            var input = new[] {1, 2, 3 };
            var expected = new List<int>
            {
                3,
                2,
                1
            };
            var subject = new ReverseArray();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i > expected.Count; i--)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
