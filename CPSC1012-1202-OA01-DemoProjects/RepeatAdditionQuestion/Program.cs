using System;

namespace RepeatAdditionQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            int attempts = 0;
            Random rand = new Random();
            int number1 = rand.Next(1, 10);
            int number2 = rand.Next(1, 10);
            int correctAnswer = number1 + number2;
            //Console.Write($"What is {number1} + {number2} = ?");
            //int userAnwer = int.Parse(Console.ReadLine());
            //attempts++;
            //while (userAnwer != correctAnswer)
            //{
            //    Console.WriteLine("Wrong answer. Try again.");
            //    Console.Write($"What is {number1} + {number2} = ?");
            //    userAnwer = int.Parse(Console.ReadLine());
            //    attempts++;
            //}           
            while (!gameOver) // while (gameOver != true)
            {              
                Console.Write($"What is {number1} + {number2} = ?");
                int userAnwer = int.Parse(Console.ReadLine());
                attempts++;
                if (userAnwer == correctAnswer)
                {
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("Wrong answer. Try again.");
                }
            }

            Console.WriteLine($"You got the correct answer in {attempts} attempt.");
        }
    }
}
