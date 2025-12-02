using System;

public class Breathing : Activity
{
    public Breathing() 
        : base("Breathing Activity", "This activity will help you relax by guiding your breathing.") {}

    public void Run()
    {
        StartActivity();
        
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4);

            Console.WriteLine("Breathe out...");
            Countdown(6);
            
            Console.WriteLine();
        }
        
        EndActivity();
    }
}