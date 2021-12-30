``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.0.1 (21A559) [Darwin 21.1.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT


```
|             Method |     Mean |   Error |  StdDev |
|------------------- |---------:|--------:|--------:|
| TestBlackPawnSetup | 945.8 ns | 1.60 ns | 1.50 ns |
| TestWhitePawnSetup | 952.9 ns | 0.61 ns | 0.54 ns |
|          InitBoard | 619.0 ns | 1.74 ns | 1.45 ns |
``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.0.1 (21A559) [Darwin 21.1.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT


```
|                         Method |     Mean |   Error |  StdDev |
|------------------------------- |---------:|--------:|--------:|
|           GetPawnMovesWhite_55 | 496.3 ns | 0.33 ns | 0.31 ns |
| GetPawnMovesWhite_AtEndOfBoard | 136.0 ns | 0.09 ns | 0.08 ns |
| GetPawnMovesBlack_AtEndOfBoard | 139.6 ns | 0.17 ns | 0.15 ns |
|           GetPawnMovesBlack_55 | 496.5 ns | 0.39 ns | 0.35 ns |
|       GetPawnMovesBlack_Origin | 619.2 ns | 1.03 ns | 0.86 ns |
|       GetPawnMovesWhite_Origin | 616.5 ns | 0.62 ns | 0.55 ns |
