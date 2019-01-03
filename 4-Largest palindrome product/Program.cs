using System;

namespace _4_Largest_palindrome_product
{
    class Program
    {
        // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.
        static void Main(string[] args)
        {
            var multiplication = 0;
            var largestPalindrome = 0;
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > i; j--)
                {
                    multiplication = i * j;
                    if (PalindromeHelper.IsPalindrome(multiplication))
                    {
                        Console.WriteLine($"Palindrome: {i} * {j} = {multiplication}");
                        largestPalindrome = multiplication > largestPalindrome ? multiplication : largestPalindrome;
                    }
                }
            }

            Console.WriteLine($"Largest Palindrome: {largestPalindrome}");
        }
    }
}
