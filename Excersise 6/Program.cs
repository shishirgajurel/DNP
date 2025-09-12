

using Excersise_6;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Example of Add methods
            int result1 = calc.Add(5, 7);
            Console.WriteLine($"5 + 7 = {result1}");

            int[] numbers = { 1, 2, 3, 4, 5 };
            int result2 = calc.Add(numbers);
            Console.WriteLine($"Sum of array [1,2,3,4,5] = {result2}");

            // Call method that asks for input and finds maximum
            Console.WriteLine("\nNow let's find the maximum of two numbers:");
            calc.DisplayMaxOfTwo();
        }
    }
}