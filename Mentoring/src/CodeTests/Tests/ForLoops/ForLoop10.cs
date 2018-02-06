﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop10 : ICodeTest
    {
        public void Run()
        {
            var data = Initialise();
            // TODO Sum up all the numbers across all the arrays

            
            for (int i = 0; i < data.Count; i++)
            {
                var sum = 0;
                for (int j = 0; j < data[i].Numbers.Length; j++)
                {
                    sum += data[i].Numbers[j];
                }

                //var sum = 0;
                //sum += data[i];
                Console.WriteLine($"The sum of object {i} = {sum}");
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
