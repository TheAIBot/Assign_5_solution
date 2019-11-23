using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Performance
{
    public class Benchmarker
    {

        //[Params(50, 200, 500, 1000)]
        [Params(100, 200, 400)]
        public int N;

        private int[] Numbers;

        [GlobalSetup]
        public void Setup()
        {
            Random rand = new Random(N);
            Numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                Numbers[i] = rand.Next(1, 20_001);
            }
        }

        [Benchmark]
        public (int, int) Solve() => Assign_5_solution.Program.Solve(Numbers);
    }

    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarker>();
        }
    }
}
