namespace Excersise_3;
internal class Program
{
    static void Main(string[] args)
    {
        // Using object initializer
        Person person = new Person { Name = "Alice" };

        // OR using constructor (if you add one later)
        // Person person = new Person("Alice");

        person.Introduce();
    }
}