﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTests.Models;

namespace CodeTests.Tests.ForLoops
{
    public class EvenNumbersInArray
    {
        public List<int> Run(IList<NumberArray> input)
        {
            var result = new List<int>();

            // TODO 1: Print all numbers from each object in data array.  
            // TODO 2: Print the even numbers from each object in data array. 
            // TODO 3: At the end of every data item, output the "Completed Item 'n'" where n is the index of the data item
            //use nested for loops

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    //var num = input[i];
                    if (input[i].Numbers[j] % 2 == 0)
                    {
                        result.Add(input[i].Numbers[j]);
                    }
                }
            }
            return result;
        }
    }
}