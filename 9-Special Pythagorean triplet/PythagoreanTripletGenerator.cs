using System;
using System.Collections.Generic;

namespace _9_Special_Pythagorean_triplet
{
    public class PythagoreanTripletGenerator
    {
        private int _maximumLimit;
        public PythagoreanTripletGenerator(int maximumLimit)
        {
            _maximumLimit = maximumLimit;
        }

        /// needToCheck - Predicate used to ensure that the sum of a^2 and b^2 is tested only if a + b doesn't exceed 1000.
        public IEnumerable<Tuple<int, int, int>> GetNextTriplet(Func<int, int, bool> needToCheck)
        {
            for (int i = 1; i < _maximumLimit; i++)
            {
                for (int j = i; j < _maximumLimit; j++)
                {
                    if (needToCheck(i, j))
                    {
                        var c = Math.Sqrt(i*i + j*j);
                        var intC = Convert.ToInt32(c);
                        if (c == intC) 
                        {
                            yield return new Tuple<int, int, int>(i, j, intC);
                        }
                    }
                }
            }
        }
    }
}