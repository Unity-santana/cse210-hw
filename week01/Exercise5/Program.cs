internal class Program
{
    private static void Main(string[] args)
    {
        // Call the welcome function
        DisplayWelcome();

        // Get the user's name
        string userName = PromptUserName();

        // Get the user's favorite number
        int userNumber = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(userNumber);

        // Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    private static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to ask for the user's name and return it
    private static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to ask for the user's favorite number
    private static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function to square the number
    private static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Function to display the result
    private static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
