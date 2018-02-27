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

        
        }
    }
}
