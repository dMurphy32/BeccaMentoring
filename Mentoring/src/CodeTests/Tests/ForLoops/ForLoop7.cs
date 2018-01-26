﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop7 : ICodeTest
    {
        public void Run()
        {
            var data = Initialise();
            // TODO Iterating through the number array classes in reverse order print the numbers in each object in order 
            // ie. print the array from obj 3 first in order, then from obj 2 in order
            // 11 12 13 14 15 6 7 8 9 10
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
