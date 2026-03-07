using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        // Ask the user for numbers until they enter 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            userNumber = int.Parse(input);

            // Do not add 0 to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Calculate the sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Calculate the average
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the largest number
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");
    }
}