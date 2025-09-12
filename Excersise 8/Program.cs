using System;
namespace OutWordApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeOutWord("<<>>", "Yay"));     // → <<Yay>>
            Console.WriteLine(MakeOutWord("<<>>", "WooHoo"));  // → <<WooHoo>>
            Console.WriteLine(MakeOutWord("[[]]", "word"));    // → [[word]]
            Console.WriteLine(MakeOutWord("{{}}", "Test"));    // → {{Test}}
        }

        // Method that inserts the word in the middle of the outer string
        static string MakeOutWord(string outer, string word)
        {
            string front = outer.Substring(0, 2); // first two characters
            string back = outer.Substring(2);     // last two characters
            return $"{front}{word}{back}";
        }
    }
}