using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        int lastDigit = percentage % 10;
        string sign = "";

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }
        if (letter == "A" && percentage >= 97)
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }


        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }

        else
        {
            Console.WriteLine("Better luck next time.");
        }      
    }
}