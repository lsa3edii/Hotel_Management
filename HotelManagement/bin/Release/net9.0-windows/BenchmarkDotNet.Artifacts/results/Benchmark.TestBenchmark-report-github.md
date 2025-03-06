```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3323)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2


```
| Method              | Mean        | Error       | StdDev      | Median      |
|-------------------- |------------:|------------:|------------:|------------:|
| SearchWithEF        |  8,222.8 μs |    53.07 μs |    94.33 μs |  8,203.1 μs |
| SearchWithDapper    | 88,597.7 μs | 1,800.27 μs | 5,279.89 μs | 87,937.9 μs |
| SearchWithEF_SP     |    227.7 μs |     5.17 μs |    15.00 μs |    227.1 μs |
| SearchWithDapper_SP | 86,074.4 μs | 1,696.09 μs | 3,058.40 μs | 85,790.0 μs |
| GetFirstWithEF      |    486.0 μs |     9.67 μs |    27.43 μs |    471.7 μs |
| GetFirstWithDapper  | 84,249.8 μs | 1,663.69 μs | 4,719.61 μs | 83,802.9 μs |
