using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop9 : ICodeTest
    {
        public void Run()
        {
            var data = Initialise();
            // TODO Print the even numbers from every second array

            for (int i = 1; i < data.Count; i = i+2)
            {
                for (int j = 0; j < data[i].Numbers.Length; j++)
                {
                    var numSet = data[i].Numbers[j];
                    if (numSet%2 == 0)
                    {
                        Console.WriteLine(numSet);
                    }
                }
            }
        }

        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray //object 1
            {
                Numbers = new[] { 1, 2, 3, 4, 5 }
            });
            result.Add(new NumberArray // object 2
            {
                Numbers = new[] { 6, 7, 8, 9, 10 }
            });
            result.Add(new NumberArray //object 3
            {
                Numbers = new[] { 11, 12, 13, 14, 15 }
            });

            return result;
        }
    }
}
