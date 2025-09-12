using System;
using System.Linq; // for Min() and Max()

namespace BigDiffApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigDiff(new int[] { 10, 3, 5, 6 }));   // → 7
            Console.WriteLine(BigDiff(new int[] { 7, 2, 10, 9 }));  // → 8
            Console.WriteLine(BigDiff(new int[] { 2, 10, 7, 2 }));  // → 8
        }

        // Method that returns the difference between max and min
        static int BigDiff(int[] numbers)
        {
            int min = numbers.Min();
            int max = numbers.Max();
            return max - min;
        }
    }
}