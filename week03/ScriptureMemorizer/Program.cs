 // ---Creative feature: added a library of scriptures and the program choses one randomly
using System;
using System.Text.Encodings.Web;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        string t1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        Reference r2 = new Reference ("John", 3, 16);
        string t2 = "For God so loved the world that he gave his only begotten Son, "
                    + "that whosoever believeth in him should not perish but have everlasting life.";

        Reference r3 = new Reference ("Psalm", 23, 1);
        string t3 = "The Lord is my shepherd; I shall not want.";

        Reference[] references = {r1, r2, r3};
        string[] texts = {t1, t2, t3};

        Random rand = new Random();
        int index = rand.Next(0, references.Length);

        Scripture scripture = new Scripture(references[index], texts[index]);
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden! Program finished");
                break;
            }
        }
    }
}