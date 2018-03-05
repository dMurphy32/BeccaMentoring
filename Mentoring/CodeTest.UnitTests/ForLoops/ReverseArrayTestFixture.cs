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
        public void Run_Invoke_ReverseArray()
        {
            //Arrange
            var input = new[] { 4, 15, 27, 423};
            var expected = new List<int>
            {
                423,
                27,
                15,
                4
            };
            var subject = new ReverseArray();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i > input.Length; i--)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }
    }
}
