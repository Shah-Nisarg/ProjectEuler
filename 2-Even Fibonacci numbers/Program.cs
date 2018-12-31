using System;

namespace _2_Even_Fibonacci_numbers
{
    class Program
    {
        const int limit = 4000000;
        static void Main(string[] args)
        {
            var fibo = new Fibo();
            long nextNumber = 0;
            long sum = 0;
            while (nextNumber < limit)
            {
                nextNumber = fibo.GetNext();
                if (nextNumber % 2 == 0)
                {
                    sum += nextNumber;
                }
            }

            Console.WriteLine($"Total sum: {sum}");
        }
    }
}
