using System;

namespace _2_Even_Fibonacci_numbers
{
    // 1, 0, 1, 1, 2, 3, 5
    public class Fibo
    {
        public long Num1 { get; set; }
        public long Num2 { get; set; }

        public Fibo()
        {
            Num1 = 1;
            Num2 = 0;
        }   

        public long GetNext()
        {
            var sum = Num1 + Num2;
            Num1 = Num2;
            Num2 = sum;
            return (long)sum;
        }
    }
}
