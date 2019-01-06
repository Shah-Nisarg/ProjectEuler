using System;

namespace _10_Summation_of_primes
{
    class Program
    {
        private const int primeNumberUpperLimit = 2000000;
        static void Main(string[] args)
        {
            long sum = 0;
            var numberToTry = 1;
            do
            {
                numberToTry++;
                
                if (PrimeHelper.IsPrime(numberToTry))
                {
                    sum += numberToTry;
                    Console.WriteLine($"Prime: {numberToTry}, Sum: {sum}");
                }
            } while (numberToTry < primeNumberUpperLimit);
        }
    }
}
