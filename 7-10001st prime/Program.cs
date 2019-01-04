using System;

namespace _7_10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generating the prime numbers up to 100.
            var limit = 10001;
            var numberToTry = 1;

            while (PrimeHelper.PrimeNumbers.Count < limit)
            {
                numberToTry += 2;
                
                if (PrimeHelper.IsPrime(numberToTry))
                {
                    Console.WriteLine($"Prime number: {numberToTry}");
                }
            }

            Console.WriteLine($"{limit}th prime number is {numberToTry}.");
        }
    }
}
