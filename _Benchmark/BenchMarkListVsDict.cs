using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace _Benchmark
{
    public class BenchMarkListVsDict
    {
        [Benchmark]
        public void DictFunc()
        {
           
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < 100000; i++)
                dict.Add(i, i);

        }


        [Benchmark]
        public void ListFunc()
        {
         
            List<int> lst = new List<int>();
            for (int i = 0; i < 10000; i++)
                lst.Add(i);


        }

    }
}