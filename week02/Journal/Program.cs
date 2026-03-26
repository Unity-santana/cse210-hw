/*
Creativity Added:
- Added extra prompts
- Automatically saves the current date
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal._entries.Add(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayJournal();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
        }
    }
}
