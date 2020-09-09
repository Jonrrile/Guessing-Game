using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessingCount = 1;
            while (guessingCount < 5)
            {
                Console.WriteLine("Welcome to the Guessing Game.");
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.WriteLine("Please enter your guess.");

                string guess = Console.ReadLine();
                // Console.WriteLine($"Your guess was {guess}.");
                string correct = "42";
                if (guess == correct)
                {
                    Console.WriteLine("Congrats! You guessed correctly.");
                    Console.WriteLine($"Your guess: {guessingCount}");
                }
                else
                {
                    Console.WriteLine("You lose ):");
                    Console.WriteLine($"Try again, your guess: {guessingCount}");
                }
                guessingCount++;
            }

        }
    }
}
