using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");

            choice = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (choice)
            {
                case 1:
                    Breathing breath = new Breathing();
                    breath.Run();
                    break;

                case 2:
                    Reflection reflect = new Reflection();
                    reflect.Run();
                    break;
                
                case 3:
                    Listing list = new Listing();
                    list.Run();
                    break;
                
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. ");
                    break;
            }
            if (choice != 4)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}