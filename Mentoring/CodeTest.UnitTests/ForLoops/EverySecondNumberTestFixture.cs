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
    public class EverySecondNumberTestFixture
    {
        [Test]
        public void Run_Invoke_EverySecondNumber()
        {
            //Arrange
            var input = new[] {1, 2, 3, 4, 5, 6};
            var expected = new List<int>
            {
                0,
                2,
                4,
                6
            };
            var subject = new EverySecondNumber();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < expected.Count; i= i +2)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
