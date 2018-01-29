using System;
using CodeTests.Tests.ForLoops;
using CodeTests.Tests.IfElse;
using CodeTests.Tests.WhileLoops;

namespace CodeTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new WhileLoop4();
            test.Run();


            Console.ReadLine();
        }
    }
}
