using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone."
    };

    private List<string> questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it different?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
        "This helps you reflect on your strengths.") {}

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Count)]);

        Console.WriteLine("\nReflect on the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(4);
        }

        EndMessage();
    }
}