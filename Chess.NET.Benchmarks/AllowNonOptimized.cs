using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Validators;

namespace Benchmarks // Note: actual namespace depends on the project name.
{
    public class AllowNonOptimized : ManualConfig
    {
        public AllowNonOptimized()
        {
            Add(JitOptimizationsValidator.DontFailOnError); // ALLOW NON-OPTIMIZED DLLS

            Add(DefaultConfig.Instance.GetLoggers().ToArray()); // manual config has no loggers by default
            Add(DefaultConfig.Instance.GetExporters().ToArray()); // manual config has no exporters by default
            Add(DefaultConfig.Instance.GetColumnProviders().ToArray()); // manual config has no columns by default
        }
    }
}