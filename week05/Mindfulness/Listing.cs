using System;
using System.Collections.Generic;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your heroes?",
    };

    public Listing() 
        : base("Listing Activity",
               "This activity helps you reflect on the good things in your life.") {}

    public void Run()
    {
        StartActivity();

        Random r = new Random();
        string prompt = _prompts[r.Next(_prompts.Count)];

        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nYou may begin in: ");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Item: ");
            items.Add(Console.ReadLine());
        }
        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndActivity();
    } 
}