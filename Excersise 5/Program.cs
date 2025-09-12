
using Excersise_5; // import the namespace

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Use Add method with two integers
            int result1 = calc.Add(5, 7);
            Console.WriteLine($"5 + 7 = {result1}");

            // Use overloaded Add method with an array
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result2 = calc.Add(numbers);
            Console.WriteLine($"Sum of array [1,2,3,4,5] = {result2}");
        }
    }
}