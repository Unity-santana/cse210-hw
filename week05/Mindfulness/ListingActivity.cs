public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    public ListingActivity()
        : base("Listing Activity",
        "List as many positive things as you can.") {}

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndMessage();
    }
}