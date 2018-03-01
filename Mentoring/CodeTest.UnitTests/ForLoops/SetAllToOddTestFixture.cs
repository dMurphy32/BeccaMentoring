using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Tests.ForLoops;
using NUnit.Framework;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class SetAllToOddTestFixture
    {
        [Test]
        public void Run_Invoke_SetAllToOdd()
        {
            //Arrange
            var input = new[] {2, 15, 12, 23, 25};
            var expected = new List<int>
            {
                2,
                0,
                12,
                0,
                0
            };
            var subject = new SetAllToOdd();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i],result[i]);
            }
        }
    }
}
