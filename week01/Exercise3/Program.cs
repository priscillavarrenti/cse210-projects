using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("I have chosen a magic number between 1 and 100. Try to guess it! ");

            while (guess != magicNumber)
            {
                Console.Write("Whats your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
            Console.WriteLine($"Congratulations! You guessed the magic number, it took you {guessCount} tries.");
            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();

            Console.WriteLine("Thank you for playing! Goodbye!");
        }
    }
}