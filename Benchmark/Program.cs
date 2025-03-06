using BenchmarkDotNet.Running;
using static Azure.Core.HttpHeader;

namespace Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestBenchmark benchmark = new();
            
            BenchmarkRunner.Run<TestBenchmark>();


            Console.WriteLine("\nSearching With Entity Framework..");
            foreach (var item in benchmark.SearchWithEF())
                Console.WriteLine(item);


            Console.WriteLine("\nSearching With Dapper..");
            foreach (var item in benchmark.SearchWithDapper())
                Console.WriteLine(item);




            Console.WriteLine("\nSearching With Entity Framework SP..");
            foreach (var item in benchmark.SearchWithEF_SP())
                Console.WriteLine(item);


            Console.WriteLine("\nSearching With Dapper SP..");
            foreach (var item in benchmark.SearchWithDapper_SP())
                Console.WriteLine(item);




            Console.WriteLine("\nFirst Reservertion With Entity Framework..");
            Console.WriteLine(benchmark.GetFirstWithEF());


            Console.WriteLine("\nFirst Reservertion With Dapper..");
            Console.WriteLine(benchmark.GetFirstWithDapper());



            Console.WriteLine("\nPress any key to exit...");
            Console.Read();
        }
    }
}
