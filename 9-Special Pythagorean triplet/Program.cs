using System;

namespace _9_Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new PythagoreanTripletGenerator(1000);

            foreach (var triplet in generator.GetNextTriplet((i, j) => i + j < 1000))
            {
                if (triplet.Item1 + triplet.Item2 + triplet.Item3 == 1000)
                {
                    Console.WriteLine($"Triplet: {triplet.Item1}, {triplet.Item2}, {triplet.Item3}");
                    Console.WriteLine($"Answer: {triplet.Item1 * triplet.Item2 * triplet.Item3}");
                    break;
                }
            }
        }
    }
}
