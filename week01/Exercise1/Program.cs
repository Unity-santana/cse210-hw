using System;

//ask the user for their first and last name, then greet them with their full name in the format "LastName, FirstName LastName"
Console.Write("what is your first name? ");
string firstName = Console.ReadLine();
Console.Write("what is your last name? ");
string lastName = Console.ReadLine();
Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

