using System;

namespace NTwiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NTwice("Hello", 2));      // → Helo
            Console.WriteLine(NTwice("Chocolate", 3));  // → Choate
            Console.WriteLine(NTwice("Chocolate", 1));  // → Ce
            Console.WriteLine(NTwice("Programming", 4)); // → Progrmming
        }

        // Method that returns first n chars + last n chars
        static string NTwice(string str, int n)
        {
            string front = str.Substring(0, n);
            string back = str.Substring(str.Length - n);
            return front + back;
        }
    }
}