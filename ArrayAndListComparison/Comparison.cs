using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace ArrayAndListComparison
{
    [MemoryDiagnoser]
    public class Comparison
    {
        private List<int> _numbers = new List<int>();

        [GlobalSetup]
        public void Setup()
        {
            for(int i = 0; i < 1000; i++)
            {
                _numbers.Add(i);
            }
        }

        [Benchmark]
        public void Array()
        {
            var array = new int[_numbers.Count];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = _numbers[i];
            }

        }

        [Benchmark]
        public void List()
        {
            var list = new List<int>();

            for (int i = 0; i < _numbers.Count; i++)
            {
                list.Add(_numbers[i]);
            }

        }

    }
}
