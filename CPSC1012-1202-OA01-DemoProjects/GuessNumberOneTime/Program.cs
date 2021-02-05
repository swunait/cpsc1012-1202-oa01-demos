using System;

namespace GuessNumberOneTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);
            Console.WriteLine($"I have a generated a random number of {randomNumber}.");

            // Prompt and read the guess number
            Console.Write("Enter your guess: ");

            int guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == randomNumber)
            {
                Console.WriteLine($"You guess the correct number {randomNumber}");
            }
            else if (guessNumber > randomNumber)
            {
                Console.WriteLine("Your guess is too high");
            }
            else
            {
                Console.WriteLine("Your guess is too low");
            }
                 
        }
    }
}
