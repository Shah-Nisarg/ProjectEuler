using System;

namespace _4_Largest_palindrome_product
{
    public static class PalindromeHelper
    {
        public static bool IsPalindrome(int number)
        {
            var numString = number.ToString().ToCharArray();
            var isPalindrome = true;
            var length = numString.Length;

            for (int i = 0; i < length; i++)
            {
                if (numString[i] != numString[length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }

                if (i >= (length - i - 1))
                {
                    break;
                }
            }

            return isPalindrome;
        }
    }
}