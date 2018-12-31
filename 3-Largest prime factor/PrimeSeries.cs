using System;
using System.Collections.Generic;

namespace _3_Largest_prime_factor
{
    // Generates a set of prime numbers that are eligible to be prime factors of given number.
    public class PrimeSeries
    {
        private long _givenNumber = 0;
        // private List<long> _primeNumbers;
        public PrimeSeries(long givenNumber)
        {
            _givenNumber = givenNumber;
        } 

        public long FindLargestPrimeFactor()
        {
            // Iterating backwards as we are looking for the largest prime.
            for (var i = 2; i <= _givenNumber / 2; i++)
            {
                if (i % 2 == 0 && i != 2)
                {
                    continue;
                }

                if (_givenNumber % i == 0 && PrimeHelper.IsPrime(i))
                {
                    var otherFactor = _givenNumber / i;
                    Console.WriteLine($"A set of factors is: {otherFactor} & {i}");
                    if (PrimeHelper.IsPrime(otherFactor))
                    {
                        return otherFactor;
                    }
                    else
                    {
                        Console.WriteLine($"{otherFactor} is not prime. Starting from scratch.");
                        _givenNumber = otherFactor;
                        i = 2;
                    }
                }

                if (i % 10000 == 0)
                {
                    Console.WriteLine($"Checked {i}...");
                }
            }

            return 1;
        }
    }
}