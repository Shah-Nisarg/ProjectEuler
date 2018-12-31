using System;

namespace _3_Largest_prime_factor
{
    public static class PrimeHelper
    {
        public static bool IsPrime(long number)
        {
            if (number % 2 == 0)
            {
                return false;
            }

            var isPrime = true;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}