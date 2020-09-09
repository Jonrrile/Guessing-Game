using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game.");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please enter your guess.");

            string guess = Console.ReadLine();
            Console.WriteLine($"Your guess was {guess}.");

        }
    }
}
