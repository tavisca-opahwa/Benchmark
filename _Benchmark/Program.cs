using System;
using BenchmarkDotNet.Running;

namespace _Benchmark
{
    partial class Program
    {
        public static void Main(String[] args)
        {
            var forVsWhile = BenchmarkRunner.Run<BenchMarkForVsWhile>();
            var forVsForeach = BenchmarkRunner.Run<BenchMarkForVsForeach>();
            var ifVsSwitch = BenchmarkRunner.Run<BenchMarkIfVsSwitch>();
            Console.ReadKey(true);
        }
    }

}



