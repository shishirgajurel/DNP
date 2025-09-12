namespace NumberPrinterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers between 0 and 10:");
            PrintEvenNumbers(10);

            Console.WriteLine("\nUneven numbers between 0 and 10:");
            PrintUnevenNumbers(10);

            Console.WriteLine("\nNumbers divisible by 3 between 0 and 20:");
            PrintNumbersDivisibleBy(20, 3);
        }

        // (b) Method to print even numbers
        static void PrintEvenNumbers(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // (c) Method to print uneven (odd) numbers
        static void PrintUnevenNumbers(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // (d) Method to print numbers divisible by y
        static void PrintNumbersDivisibleBy(int x, int y)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % y == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}