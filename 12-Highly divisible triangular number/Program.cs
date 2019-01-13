using System;

namespace _12_Highly_divisible_triangular_number
{
    class Program
    {
        const int NEEDED_FACTORS = 500;
        static void Main(string[] args)
        {
            var foundIt = false;
            
            foreach (var number in TriangularNumberGenerator.Get())
            {
                var helper = new FactorHelper(number);
                foundIt = helper.HasMoreThanKFactors(NEEDED_FACTORS);
                Console.WriteLine($"{number} has {NEEDED_FACTORS} factors? : {foundIt}");
                
                if (foundIt) break;
            }
        }
    }
}
