using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessingCount = 0;
            while (guessingCount < 4)
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
                }
                else
                {
                    Console.WriteLine("You lose ):");
                }
                guessingCount++;
            }

        }
    }
}
