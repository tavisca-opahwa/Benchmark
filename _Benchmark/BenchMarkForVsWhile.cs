using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
 namespace _Benchmark
 {
        public class BenchMarkForVsWhile
        {
            [Benchmark]
            public void WhileFunction()
            {
                List<int> list1 = new List<int>();
                int i = 0;
                while (i < 1000000)
                {
                    list1.Add(i);
                    i++;
                }

            }
            [Benchmark]
            public void ForFunction()
            {
                List<int> list1 = new List<int>();
                for (int i = 0; i < 1000000; i++)
                    list1.Add(i);
            }
        }
    
 }