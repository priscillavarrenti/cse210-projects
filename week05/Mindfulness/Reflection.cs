using System;
using System.Collections.Generic;

public class Reflection : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What did you learn about yourself?",
        "How can you remember this experience in the future?"
    };

    public Reflection() 
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.") {}

    public void Run()
    {
        StartActivity();

        Random r = new Random();
        string prompt = _prompts[r.Next(_prompts.Count)];

        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"--- {prompt} ---");

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string q = _questions[r.Next(_questions.Count)];
            Console.WriteLine($"> {q}");
            ShowSpinner(5);
        }
        EndActivity();
    }
    
}
