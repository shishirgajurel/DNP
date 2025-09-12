namespace Excersise_6;

public class Calculator
{
    // Add method for two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded Add method for an array of integers
    public int Add(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    // New method: reads two numbers and displays the maximum
    public void DisplayMaxOfTwo()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int max = Math.Max(num1, num2);
        Console.WriteLine($"The maximum of {num1} and {num2} is {max}");
    }
}