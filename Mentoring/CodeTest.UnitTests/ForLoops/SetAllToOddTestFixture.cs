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
        public void Run_Invoke_SetAllToOddTest()
        {
            //Arange
            var input = new[] {1, 2, 3, 4};
            var expected = new List<int>
            {
                0,
                2,
                0,
                4
            };
            var subject = new SetAllToOdd();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
