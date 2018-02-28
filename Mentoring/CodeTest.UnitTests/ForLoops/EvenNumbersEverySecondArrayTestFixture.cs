using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;
using CodeTests.Tests.ForLoops;
using NUnit.Framework;

namespace CodeTest.UnitTests.ForLoops
{
    [TestFixture]
    public class EvenNumbersEverySecondArrayTestFixture
    {
        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 1, 2, 3, 4, 5 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 6, 7, 8, 9, 10 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 11, 12, 13, 14, 15 }
            });
            result.Add(new NumberArray
            {
                Numbers = new List<int> { 724, 53, 44, 16, 15 }
            });

            return result;
        }

       
    }
}

