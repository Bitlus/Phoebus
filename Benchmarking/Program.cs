using BenchmarkDotNet.Running;
using Benchmarking;

/*
 * Benchmark project is mainly to see what the memory characteristics of the functions are.
 * This mostly for curiosity sake and also serves as a sanity check to make sure the functions aren't allocating lots of memory.
 */

var summary = BenchmarkRunner.Run<StringExtensionsBenchmarks>();