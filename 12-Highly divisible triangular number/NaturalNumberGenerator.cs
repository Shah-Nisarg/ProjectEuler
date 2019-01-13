using System;
using System.Collections.Generic;

namespace _12_Highly_divisible_triangular_number
{
    public static class NaturalNumberGenerator
    {
        public static IEnumerable<long> Get()
        {
            long i = 1;
            while(true)
            {
                yield return i++;
            }
        }
    }
}
        
