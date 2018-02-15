using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Models
{
    public class NumberArray
    {
        public int[] Numbers { get; set; }

        public List<NumberArray> Run(int[] input)
        {
            //var result = new List<int>();
            var result = new List<NumberArray>();

            result.Add(new NumberArray
            //{
            //    //Numbers = new[] { 1, 2, 3, 4, 5 }
            //});
            //result.Add(new NumberArray
            //{
            //    //Numbers = new[] { 6, 7, 8, 9, 10 }
            //});
            //result.Add(new NumberArray
            {
               // Numbers = new[] { 11, 12, 13, 14, 15 }
            });

            return result;
            
        }
    }
}
