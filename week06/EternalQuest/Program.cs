using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {score} points");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");

        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if( type == 2)
        {
            goals. Add(new EternalGoal(name, description, points));
        }
        else
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

//list goals
    static void ListGoals()
    {
        Console.WriteLine("Your Goals: ");
        int i = 1;
        foreach (var g in goals)
        {
            Console.WriteLine($"{i}. {g.GetStatus()}");
            i++;
        }
    }

//save goals
    static void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(score);
            foreach (var g in goals)
            {
                file.WriteLine(g.SaveFormat());
            }
        }
        Console.WriteLine("Goals saved succesfully!");
    }

//load goals
    static void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        score = int .Parse(lines[0]);
        goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            goals.Add(GoalLoader.Load(lines[i]));
        }
        Console.WriteLine("Goals loaded succesfully!");
    }

//record event
    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int g = int.Parse(Console.ReadLine()) -1;

        int pts = goals[g].RecordEvent();
        Console.WriteLine($"\nCongratulations! You earned {pts} points!");
        score += pts;
    }
}