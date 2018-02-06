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
    public class ForLoop4 : ICodeTest
    {
        public void Run()
        {
            var data = Initialise();

            // TODO 1: Print all numbers from each object in data array.  
            // TODO 2: Print the even numbers from each object in data array. 
            // TODO 3: At the end of every data item, output the "Completed Item 'n'" where n is the index of the data item
            //use nested for loops


            //all number from each object in data array
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Numbers.Length; j++)
                {
                    Console.Write("{0}, ", data[i].Numbers[j]);
                }
                Console.WriteLine();
            }

            //even numbers from each object in data array
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Numbers.Length; j++)
                {
                    var numSet = data[i].Numbers[j];
                    if (numSet % 2 ==0)
                    {
                        Console.Write("{0}, ", numSet);
                    }
                }
                Console.WriteLine();
            }

            //At the end of every data item, output the "Completed Item 'n'" where n is the index of the data item
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Numbers.Length; j++)
                {
                    Console.Write("{0}, ", data[i].Numbers[j]);
                }
                Console.WriteLine("The Completed Item {0}", i);
            }
        }


        private IList<NumberArray> Initialise()
        {
            var result = new List<NumberArray>();

            result.Add(new NumberArray
            {
                Numbers = new[] { 1, 2, 3, 4, 5 }
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

    }
}