using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;
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
            var input = new[] { 3, 5, 22, 7, 9, 56};
            var expected = new List<int>
            {
                5,
                7,
                56
            };
            var subject = new EverySecondNumber();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Assert.AreEqual(result, expected);
                }
                
            }
        }
    }
}
