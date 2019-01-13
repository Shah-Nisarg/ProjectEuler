using System;
using System.Linq;
using System.Collections.Generic;

namespace _12_Highly_divisible_triangular_number
{
    public class FactorHelper
    {
        private long Number { get; set; }
        private int LargestPossibleFactor { get; set; }
        private List<long> PossibleFactors { get; set; }
        private List<long> Factors { get; set; }

        public FactorHelper(long number)
        {
            Number = number;
            LargestPossibleFactor = Convert.ToInt32(Math.Ceiling(Math.Sqrt(number)));
            PossibleFactors = NaturalNumberGenerator.Get().Take(LargestPossibleFactor).ToList();
            Factors = new List<long>();
        }

        public bool HasMoreThanKFactors(int k)
        {
            bool? HasMoreThanKPossibleFactors() 
            {
                if ((PossibleFactors.Count + Factors.Count) < k)
                {
                    return false;
                }
                return null;
            }

            if (!(HasMoreThanKPossibleFactors() ?? true))
            {
                return false;
            }

            // Starting x from 1 to Sqrt(Number), check if a number is a factor or not.
            // If yes, add to the list of factors, else, remove multiples of x from the list of possible factors.
            while (PossibleFactors.Count > 0)
            {
                var x = PossibleFactors[0];

                if (Number % x == 0) 
                {
                    Factors.Add(x);
                    Factors.Add(Number / x);
                    PossibleFactors.Remove(x);
                }
                else 
                {
                    // If number is not divisble by 2, multiples of 2 will not be divisors of number.
                    foreach (var item in PossibleFactors.ToArray())
                    {
                        if (item % x == 0)
                        {
                            PossibleFactors.Remove(item);
                        }
                    }
                }

                if (Factors.Count >= k)
                {
                    return true;
                }

                if (!(HasMoreThanKPossibleFactors() ?? true))
                {
                    return false;
                }
            }

            throw new Exception("Something went wrong.."); 
        }
    }
}
