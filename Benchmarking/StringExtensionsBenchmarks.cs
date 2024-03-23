using Phoebus;
using BenchmarkDotNet.Attributes;

namespace Benchmarking;

[MemoryDiagnoser]
public class StringExtensionsBenchmarks
{
    public string input = "abcdefghijklmnopqrstuvwxy?";

    [Benchmark]
    public bool IsAlphabetical() 
    {
        return input.IsAlphabetical();
    }

    [Benchmark]
    public bool IsAlphanumeric() 
    {
        return input.IsAlphanumeric();
    }

    [Benchmark]
    public bool IsNumeric() 
    {
        return input.IsNumeric();
    }

    [Benchmark]
    public bool IsInCharacterSet() 
    {
        return input.IsInCharacterSet("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~!@#$%^&*()_+`-=[]\\{}|;':\",./<>?");
    }
}
