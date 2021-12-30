using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Chess.NET.Tests.Units;
using Chess.NET.Tests.Board;

namespace Benchmarks // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<BoardTest>(new AllowNonOptimized());
            BenchmarkRunner.Run<PawnTests>(new AllowNonOptimized());
        }
    }
}