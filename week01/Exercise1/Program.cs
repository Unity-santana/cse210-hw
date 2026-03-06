using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("what is you first name? ");
        string firstName = Console.ReadLine();
        Console.Write("what is you last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}
