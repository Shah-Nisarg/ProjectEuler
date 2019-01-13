using System;

namespace _14_Longest_Collatz_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long maxLength = 0;
            var numberProducingMaxLength = 0;

            for (int i = 1; i < 1000000; i++)
            {
                var length = CollatzSequenceHelper.GetLengthOfSequence(i);

                if (length > maxLength)
                {
                    Console.WriteLine($"Length of sequence for {i} is {length}");    
                    maxLength = length;
                    numberProducingMaxLength = i;
                }
            }
        }
    }
}
