namespace Excersise_5;

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
}