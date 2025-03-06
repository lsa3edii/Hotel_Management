```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3323)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2


```
| Method              | Mean        | Error       | StdDev      | Median      |
|-------------------- |------------:|------------:|------------:|------------:|
| SearchWithEF        |  8,874.2 μs |   155.62 μs |   412.69 μs |  8,706.4 μs |
| SearchWithDapper    | 77,798.1 μs | 1,541.82 μs | 4,373.89 μs | 77,213.9 μs |
| SearchWithEF_SP     |    202.8 μs |     0.97 μs |     0.81 μs |    202.6 μs |
| SearchWithDapper_SP | 75,383.5 μs | 1,474.45 μs | 2,503.73 μs | 74,970.6 μs |
| GetFirstWithEF      |    452.5 μs |     8.63 μs |     7.21 μs |    451.6 μs |
| GetFirstWithDapper  | 70,160.5 μs | 1,340.45 μs | 1,253.85 μs | 70,264.1 μs |
