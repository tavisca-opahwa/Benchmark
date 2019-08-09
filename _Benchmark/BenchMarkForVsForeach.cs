using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace _Benchmark
{
   public class BenchMarkForVsForeach
   {
        List<int> list = new List<int>();
        public BenchMarkForVsForeach()
        {
            for (int i = 0; i < 1000000; i++)
                list.Add(i);
        }
        [Benchmark]
        public void ForFunction()
        {
            List<int> forList = new List<int>();
            for (int i = 0; i < list.Count; i++)
                forList.Add(list[i]);
        }
        [Benchmark]
        public void ForeachFunction()
        {
            List<int> foreachList = new List<int>();
            foreach (var x in list)
                foreachList.Add(x);
        }
    }
}