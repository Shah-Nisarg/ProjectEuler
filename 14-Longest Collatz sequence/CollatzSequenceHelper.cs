using System;
using System.Collections.Generic;

namespace _14_Longest_Collatz_sequence
{
    public static class CollatzSequenceHelper
    {
        private static Dictionary<long, long> _lengthsOfSequenceFromNumber;

        static CollatzSequenceHelper()
        {
            _lengthsOfSequenceFromNumber = new Dictionary<long, long>();
            _lengthsOfSequenceFromNumber[1] = 1;
        }

        // Collatz sequence:
        // n => n / 2, if n is even
        // n => 3n + 1, if n is odd
        public static long GetLengthOfSequence(long num)
        {   
            if (_lengthsOfSequenceFromNumber.ContainsKey(num))
            {
                return _lengthsOfSequenceFromNumber[num];
            }
            else if(num % 2 == 0)
            {
                _lengthsOfSequenceFromNumber[num] = GetLengthOfSequence(num / 2) + 1;
            }
            else
            {
                _lengthsOfSequenceFromNumber[num] = GetLengthOfSequence((num * 3) + 1) + 1;
            }
            
            return _lengthsOfSequenceFromNumber[num];
        }
    }
}