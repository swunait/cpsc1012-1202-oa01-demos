/*  Purpose:    Coin Toss Game
 * 
 *  Input:      User guess (0 for head, 1 for tail)
 *  
 *  Process:    Determine if the user guess is correct
 *  
 *  Output:     A message indicating if the user guess is correct
 * 
 * */
using System;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 0 and 1 for the coinFaceValue
            Random rand = new Random();             // Create a Random object to generating random numbers
            int coinFaceValue = rand.Next(0, 2);    // generate a random number between 0 and 1
            Console.WriteLine($"The coinFaceValue is {coinFaceValue}");

            // Declare variable to store userGuessCoinFaceValue
            int userGuessCoinFaceValue;

            // Prompt and read in the userGuessCoinFaceValue
            Console.WriteLine("Coin Toss Game");
            Console.WriteLine("I have tossed the coin. Can you guess its coin face value?");
            Console.Write("Enter 0 for Head and 1 for Tail: ");
            userGuessCoinFaceValue = int.Parse(Console.ReadLine());

            // Determine if the userGuessCoinFaceValue equals coinFaceValue and display appropriate message
            if (userGuessCoinFaceValue == coinFaceValue)
            {
                Console.WriteLine("Your guess is correct.");
            }
            else
            {
                Console.WriteLine("Your guess is incorrect.");
            }
        }
    }
}
