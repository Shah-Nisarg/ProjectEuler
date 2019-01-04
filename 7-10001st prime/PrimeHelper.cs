using System;
using System.Collections.Generic;

namespace _7_10001st_prime
{
    public static class PrimeHelper
    {
        public static List<long> PrimeNumbers { get; set; }

        static PrimeHelper() 
        {
            PrimeNumbers = new List<long>();
            PrimeNumbers.Add(2);
        }

        public static bool IsPrime(long number)
        {
            foreach (var primeNum in PrimeNumbers)
            {
                if (number % primeNum == 0 && number != primeNum) 
                {
                    return false;
                }

                if (primeNum >= Math.Sqrt(number))
                {
                    break;
                }
            }

            PrimeNumbers.Add(number);
            return true;
        }
    }
}