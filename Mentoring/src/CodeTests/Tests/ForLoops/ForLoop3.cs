using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTests.Tests.ForLoops
{
    public class ForLoop3 : ICodeTest
    {
        public void Run()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6 };

            // TODO: Create new array that is the reverse of the original

            for (int i = array.Length; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
