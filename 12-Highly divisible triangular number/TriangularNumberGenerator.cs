using System;
using System.Collections.Generic;

namespace _12_Highly_divisible_triangular_number
{
    public static class TriangularNumberGenerator
    {
        public static IEnumerable<long> Get()
        {
            long sum = 0;
            foreach (var number in NaturalNumberGenerator.Get())
            {
                sum += number;
                yield return sum;
            }
        }
    }
}