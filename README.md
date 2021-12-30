``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.0.1 (21A559) [Darwin 21.1.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT
  Job-SNMOCD : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT

IterationCount=10  LaunchCount=3  WarmupCount=10  

```
|             Method |     Mean |   Error |  StdDev |
|------------------- |---------:|--------:|--------:|
| TestBlackPawnSetup | 944.9 ns | 3.58 ns | 5.25 ns |
| TestWhitePawnSetup | 953.3 ns | 5.43 ns | 8.12 ns |
|          InitBoard | 617.8 ns | 1.70 ns | 2.49 ns |
``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.0.1 (21A559) [Darwin 21.1.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT
  Job-SNMOCD : .NET 6.0.1 (6.0.121.56705), Arm64 RyuJIT

IterationCount=10  LaunchCount=3  WarmupCount=10  

```
|                                      Method |     Mean |   Error |   StdDev |   Median |
|-------------------------------------------- |---------:|--------:|---------:|---------:|
|                        GetPawnMovesWhite_55 | 495.4 ns | 7.85 ns | 11.00 ns | 488.0 ns |
|                        GetPawnMovesBlack_55 | 488.4 ns | 2.65 ns |  3.89 ns | 486.2 ns |
|                    GetPawnMovesBlack_Origin | 608.2 ns | 2.44 ns |  3.65 ns | 609.5 ns |
|                    GetPawnMovesWhite_Origin | 606.7 ns | 3.43 ns |  5.03 ns | 608.8 ns |
|              GetPawnMovesWhite_AtEndOfBoard | 135.8 ns | 0.79 ns |  1.18 ns | 135.5 ns |
|              GetPawnMovesBlack_AtEndOfBoard | 134.5 ns | 0.82 ns |  1.17 ns | 134.0 ns |
|         GetPawnMovesBlack_AtLeftEdgeOfBoard | 488.4 ns | 2.51 ns |  3.59 ns | 486.2 ns |
|         GetPawnMovesWhite_AtLeftEdgeOfBoard | 484.9 ns | 2.83 ns |  3.97 ns | 485.6 ns |
| GetPawnMovesBlack_AtRightEdgeOfBoard_Origin | 484.1 ns | 2.10 ns |  3.07 ns | 485.5 ns |
| GetPawnMovesWhite_AtRightEdgeOfBoard_Origin | 485.6 ns | 0.69 ns |  0.97 ns | 485.7 ns |
|  GetPawnMovesBlack_AtRightEdgeOfBoard_Rank4 | 366.7 ns | 2.24 ns |  3.28 ns | 365.1 ns |
|  GetPawnMovesWhite_AtRightEdgeOfBoard_Rank4 | 376.3 ns | 3.99 ns |  5.73 ns | 378.1 ns |
