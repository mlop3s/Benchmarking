using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarking
{
    public class DateTimeBenchmark
    {
        [Params(1000, 10000)]
        public int N;

        [Benchmark]
        public void DateTimeNow()
        {
            for (int i = 0; i < N; i++)
            {
                var now = DateTime.Now;
            }
        }

        [Benchmark]
        public void DateTimeUtcNow()
        {
            for (int i = 0; i < N; i++)
            {
                var now = DateTime.UtcNow;
            }
        }

        [Benchmark]
        public void TimeStamp()
        {
            for (int i = 0; i < N; i++)
            {
                var now = System.Diagnostics.Stopwatch.GetTimestamp();
            }
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<DateTimeBenchmark>();
        }
    }
}
