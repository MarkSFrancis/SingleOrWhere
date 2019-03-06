``` ini

BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17134.590 (1803/April2018Update/Redstone4)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
Frequency=2062499 Hz, Resolution=484.8487 ns, Timer=TSC
.NET Core SDK=2.2.200
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


```
|      Method |     Mean |    Error |    StdDev |
|------------ |---------:|---------:|----------:|
|      Single | 371.6 us | 9.546 us |  8.930 us |
| WhereSingle | 389.4 us | 7.783 us |  7.280 us |
|       First | 397.5 us | 8.178 us | 18.791 us |
|  WhereFirst | 374.5 us | 7.201 us |  7.395 us |
