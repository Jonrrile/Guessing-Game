using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game... Guess the number?");
            string answer = Console.ReadLine();
            string correctNumber = "42";
            // Console.WriteLine($"You guessed {answer}.. that is incorrect!");
            if (answer == correctNumber)
            {
                Console.Write("You are correct!");
            }
            else
            {
                Console.WriteLine("Try again?");
                answer = Console.ReadLine();
            }

        }
    }
}