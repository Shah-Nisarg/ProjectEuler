using System;

namespace _5_Smallest_multiple
{
    class Program
    {
        const int N = 20;

        static void Main(string[] args)
        {
            int number = 0;
            while(true)
            {
                number++;
                if (IsNumberDivisibleBy1ToN(number))
                {
                    break;
                }
            }

            Console.WriteLine($"{number} is divisible by all numbers between 1 to {N}.");
        }

        static bool IsNumberDivisibleBy1ToN(int number)
        {
            for (int i = N; i > 1; i--)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
