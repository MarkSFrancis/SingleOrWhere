using BenchmarkDotNet.Running;
using System;

namespace SingleOrWhere
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Benchmarking Enumerable...");
            BenchmarkRunner.Run<WhereEnumerable>();

            Console.WriteLine($"Finished Enumerable benchmark. Press {ConsoleKey.Enter} to continue");
            Console.ReadLine();

            Console.WriteLine("Benchmarking Queryable...");
            BenchmarkRunner.Run<WhereQueryable>();
            Console.WriteLine($"Finished Queryable benchmark. Press {ConsoleKey.Enter} to exit");
            Console.ReadLine();
        }
    }
}
