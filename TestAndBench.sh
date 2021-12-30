dotnet test Chess.NET.sln && dotnet run --project Chess.NET.Benchmarks/Chess.NET.Benchmarks.csproj --configuration Release
cat BenchmarkDotNet.Artifacts/results/*.md > README.md