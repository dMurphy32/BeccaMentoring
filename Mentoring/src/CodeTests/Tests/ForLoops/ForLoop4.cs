using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop4 : ICodeTest
    {
        public void Run()
        {
            var data = Initialise();

            // TODO 1: Print the even numbers from each object in data array. 
            // TODO 2: At the end of every data item, output the "Completed Item 'n'" where n is the index of the data item
        }

        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray
            {
                Numbers = new [] {1, 2, 3, 4, 5}
            });
            result.Add(new NumberArray
            {
                Numbers = new[] { 6, 7, 8, 9, 10 }
            });
            result.Add(new NumberArray
            {
                Numbers = new[] { 11, 12, 13, 14, 15 }
            });

            return result;
        }

        private class NumberArray
        {
            public int[] Numbers { get; set; }
        }
    }
}
