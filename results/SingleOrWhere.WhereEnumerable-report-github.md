``` ini

BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17134.590 (1803/April2018Update/Redstone4)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
Frequency=2062499 Hz, Resolution=484.8487 ns, Timer=TSC
.NET Core SDK=2.2.200
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


```
|      Method |     Mean |    Error |   StdDev |
|------------ |---------:|---------:|---------:|
|      Single | 99.03 ns | 1.982 ns | 2.778 ns |
| WhereSingle | 94.49 ns | 1.914 ns | 5.241 ns |
|       First | 72.74 ns | 1.608 ns | 4.639 ns |
|  WhereFirst | 70.55 ns | 1.420 ns | 2.737 ns |
