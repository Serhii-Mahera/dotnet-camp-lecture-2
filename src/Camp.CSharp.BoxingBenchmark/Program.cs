using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Camp.CSharp.BoxingBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchy>();
        }
    }

    [MemoryDiagnoser]
    public class Benchy
    {
        private static int Number = 125;
        private static object NumberBoxed = 125;
        private static int LoopCount = 1_000_000;

        [Benchmark]
        public object Boxing()
        {
            object result = null;
            for(int i = 0; i < LoopCount; i++)
            {
                result = Number;
            }

            return result;
        }

        [Benchmark]
        public int Unboxing()
        {
            int result = 0;
            for(int i = 0; i < LoopCount; i++)
            {
                result = (int)NumberBoxed;
            }

            return result;
        }

        [Benchmark]
        public int SimpleInt()
        {
            int result = 0;
            for(int i = 0; i < LoopCount; i++)
            {
                result = Number;
            }

            return result;
        }
    }
}
