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
    public class NumbersInReverseTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray 
            {
                Numbers = new List<int> { 1, 2, 3, }
            });
            result.Add(new NumberArray 
            {
                Numbers = new List<int> { 6, 7, 8,}
            });
            result.Add(new NumberArray 
            {
                Numbers = new List<int> { 11, 12, 13, }
            });

            return result;
        }

        [Test]
        public void Run_Invoke_NumbersInReverseTest()
        {
            //Arrange
            var input = Initialise();
            var expected = new List<int>
            {
                3,
                2,
                1,
                8,
                7,
                6,
                13,
                12,
                11
            };
            var subject = new NumbersInReverse();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = input[i].Numbers.Count; j >=0; j--)
                {
                    Assert.AreEqual(expected[i], result[i]);
                }
            }
        }
    }
}
