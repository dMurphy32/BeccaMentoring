using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Tests.ForLoops;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class MultiplyArrayBy2TestFixture
    {
        [Test]
        public void Run_Invoke_ReturnsArrayMultipliedBy2()
        {
            //Arrange
            var input = new[] {1, 2, 3};
            var expected = new List<int>
            {
                2,
                4,
                6
            };
            //last step in arrange is creating Subject(subject under test)
            var subject = new MultiplyArrayBy2();

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
