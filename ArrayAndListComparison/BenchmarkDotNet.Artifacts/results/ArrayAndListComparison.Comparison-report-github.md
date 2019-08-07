``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742190 Hz, Resolution=364.6720 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
| Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |---------:|----------:|----------:|---------:|-------:|------:|------:|----------:|
|  Array | 1.038 us | 0.0257 us | 0.0746 us | 1.029 us | 1.9150 |     - |     - |   3.93 KB |
|   List | 3.287 us | 0.0874 us | 0.2509 us | 3.200 us | 4.0131 |     - |     - |   8.23 KB |
