using System;

namespace RockPaperScissorGame
{
    class Program
    {
        static int GenerateComputerHand(Random rand, int minValue, int maxValue)
        {
            int computerHand = 1;
            computerHand = rand.Next(minValue, maxValue + 1);
            return computerHand;
        }
        static string ShowHandName(int handValue)
        {
            string handName;
            switch (handValue)
            {
                case 1:
                    handName = "Rock";
                    break;
                case 2:
                    handName = "Paper";
                    break;
                case 3:
                    handName = "Scissor";
                    break;
                default:
                    handName = "Invalid Hand";
                    break;
            }
            return handName;
        }

        static void DisplayPlayerHand(string playerName, int hand)
        {
            string handName = ShowHandName(hand);
            Console.WriteLine($"The {playerName} showed {handName}");
        }

        static int PromptForPlayerHandNumber()
        {
            int playerHandNumber = 0;
            bool validInput = false;
            
            while (!validInput)
            {
                Console.WriteLine("Enter your hand (1 - Rock, 2 - Paper, 3 - Scissor) :");
                try
                {
                    playerHandNumber = int.Parse(Console.ReadLine());
                    if (playerHandNumber >= 1 && playerHandNumber <= 3)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input value. Please enter a value between 1 and 3.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input value. Please enter an integer value.");
                }
            }
            return playerHandNumber;
        }

        static void ShowWinner(int computerHand, int playerHand)
        {
            // Check if it is a tie game.
            if (computerHand == playerHand)
            {
                Console.WriteLine("It's a tie game");
            }
            else // Computer or Player has won the game
            {
                if (computerHand == Rock)
                {
                    if (playerHand == Paper)
                    {
                        Console.WriteLine("Paper covers Rock");
                        Console.WriteLine("Player wins!");
                    }
                    else // othterwise playerHand must be Scissor
                    {
                        Console.WriteLine("Rock crushes scissor");
                        Console.WriteLine("Computer wins!");
                    }
                }
                else if (computerHand == Paper)
                {
                    if (playerHand == Rock)
                    {
                        Console.WriteLine("Paper covers Rock");
                        Console.WriteLine("Computer wins!");
                    }
                    else // otherwise playerHand must be Scissor
                    {
                        Console.WriteLine("Scissors cut paper");
                        Console.WriteLine("Player wins!");
                    }
                }
                else /// must be Scissor
                {
                    if (playerHand == Rock)
                    {
                        Console.WriteLine("Rock crushes scissor");
                        Console.WriteLine("Player wins!");
                    }
                    else // otherwise must be Paper
                    {
                        Console.WriteLine("Scissors cut paper");
                        Console.WriteLine("Computer wins!");
                    }
                }
            }
        }

       static char PromptForYesOrNo(string prompt)
        {
            char charInput = 'y';
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine(prompt);
                try
                {
                    charInput = char.Parse(Console.ReadLine());
                    charInput = char.ToLower(charInput);
                    if (charInput == 'y' || charInput == 'n')
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter y or n.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. You must enter a single character.");
                }
            }
            return charInput;
        }

        // Define constants to help track the name of the 
        static int Rock = 1;
        static int Paper = 2;
        static int Scissor = 3;

        static void Main(string[] args)
        {
            Random keygen = new Random();
            int computerHand;
            int humanPlayerHand;
            char playAgainChoice = 'y';

            while (playAgainChoice == 'y')
            {
                computerHand = GenerateComputerHand(keygen, Paper, Scissor);
                humanPlayerHand = PromptForPlayerHandNumber(); ;
                DisplayPlayerHand("Human Player", humanPlayerHand);
                DisplayPlayerHand("Computer", computerHand);
                ShowWinner(computerHand, humanPlayerHand);

                playAgainChoice = PromptForYesOrNo("Do you want to player another round (y/n): ");
                if (playAgainChoice == 'y')
                {
                    Console.Clear();
                }

            }
            Console.WriteLine("Good-bye and thanks for playing");


        }
    }
}
