using System;

namespace _3_Largest_prime_factor
{
    class Program
    {
        const long numberToFactor = 600851475143;

        // The prime factors of 13195 are 5, 7, 13 and 29.
        // What is the largest prime factor of the number 600851475143 ?
        static void Main(string[] args)
        {
            var primeSeries = new PrimeSeries(numberToFactor);
            var largestPrimeFactor = primeSeries.FindLargestPrimeFactor();
            Console.WriteLine($"Largest prime factor of {numberToFactor} is {largestPrimeFactor}.");
        }
    }
}
