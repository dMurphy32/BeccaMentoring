using System;
using System.Collections;
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
    public class NumbersInReverseTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 5, 6, 10, 3 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 66, 14, 5, 19 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 14, 15 }
            });

            return result;
        }

        [Test]
        public void Run_Invoke_NumbersInReverse()
        {
            //Arrange
            var input = Initialise();
            var expected = new List<int>
            {
                3,
                10,
                6,
                5,
                19,
                5,
                14,
                66,
                15,
                14
            };
            var subject = new NumbersInReverse();

            //Act
            var result = subject.Run(input);

            //Assert
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = input[i].Numbers.Count -1; j >= 0; j--)
                {
                 Assert.AreEqual(result, expected);   
                }
                
            }
        }
    }
}

