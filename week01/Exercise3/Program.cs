using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a random number generator
        Random randomGenerator = new Random();

        // Generate the magic number between 1 and 100
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1; // variable to store the user's guess

        // Keep looping until the user guesses correctly
        while (guess != magicNumber)
        {
            // Ask the user for their guess
            Console.Write("What is your guess? ");

            // Read the guess and convert it to an integer
            guess = int.Parse(Console.ReadLine());

            // Check if the guess is lower than the magic number
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            // Check if the guess is higher than the magic number
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            // If neither condition above happens, the guess is correct
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
