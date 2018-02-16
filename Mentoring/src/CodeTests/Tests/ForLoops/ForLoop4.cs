using System;
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


            //all number from each object in data array
            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = 0; j < input.Length; j++)
            //    {
            //        Console.Write("{0}, ", input[i]);
            //        result.Add(input[i]);
            //    }
            //    Console.WriteLine();
            //}

            //return result;

            ////even numbers from each object in data array
            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = 0; j < input[i]; j++)
            //    {
            //        var numSet = input[i];
            //        if (numSet % 2 == 0)
            //        {
            //            Console.Write("{0}, ", numSet);
            //            result.Add(input[i]);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //return result;

            ////At the end of every data item, output the "Completed Item 'n'" where n is the index of the data item
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Numbers.Count; j++)
                {
                    Console.Write("{0}, ", input[i].Numbers[j]);
                    result.Add(input[i].Numbers[j]);
                }
                Console.WriteLine("The Completed Item {0}", i);
            }

            return result;
        }
    }
}