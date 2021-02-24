using System;

namespace MathTutor01
{
    class Program
    {
        // Define a new method named PromptForInteger that prompts the user to enter 
        // an integer value and return it. If the input value is not value,
        // re-prompt the user to enter the value again until it is valid.
        //      Input: prompt - the message to show the user
        //      Return: the integer value entered by the user
        static int PromptForInteger(string message)
        {
            int integerValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine(message);
                validInput = int.TryParse(Console.ReadLine(), out integerValue);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input! You must enter an integer value for the answer");
                }
            }

            return integerValue;
        }

        static void Main(string[] args)
        {
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Define constants for the minimum and maximum number to generate
            const int MinNumber = 1;
            const int MaxNumber = 99;
            // Generate two random bumbers between MinNumber and MaxNumber
            int number1 = rand.Next(MinNumber, MaxNumber + 1);
            int number2 = rand.Next(MinNumber, MaxNumber + 1);
            // Calculate the correct answer
            int correctAnswer = number1 + number2;

            //// Declare a boolean flag to determine if input value is valid
            //bool validInput = false;
            //int userAnswer = 0;

            //while (!validInput)
            //{               
            //    // Prompt for the addition question answer
            //    Console.WriteLine($"What is {number1} + {number2} = ?");
            //    //try
            //    //{
            //    //    userAnswer = int.Parse(Console.ReadLine());
            //    //    validIput = true;
            //    //}
            //    //catch
            //    //{
            //    //    Console.WriteLine("Invalid input! You must enter an integer value for the answer");
            //    //}

            //    validInput = int.TryParse(Console.ReadLine(), out userAnswer);
            //    if (!validInput)
            //    {
            //        Console.WriteLine("Invalid input! You must enter an integer value for the answer");
            //    }
            //}

            int userAnswer = PromptForInteger($"What is {number1} + {number2} = ?");

           
            // Determine if the user answer is correct or not
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("You got the correct answer.");
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer {correctAnswer}");
            }

        }
    }
}
