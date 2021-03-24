using System;

using System.Collections.Generic;   // for List class
using System.IO;    // for StreamReader and StreamWriter

namespace HockerPlayerInfo
{
    class Program
    {
        /// <summary>
        /// Add a single HockeyPlayer object to the playerList
        /// </summary>
        /// <param name="playerList">A list of hockey players</param>
        /// <returns>The number of players in the list</returns>
        static int AddHockeyPlayer(List<HockeyPlayer> playerList)
        {
            int playerCount = 0;
            // Create a new HockeyPlayer object
            HockeyPlayer player1 = new HockeyPlayer();
            // Prompt and read the Name of the HockeyPlayer
            Console.Write("Enter the player name: ");
            player1.Name = Console.ReadLine();
            // Prompt and read the Number of the HockeyPlayer
            Console.Write("Enter the player number: ");
            player1.Number = int.Parse(Console.ReadLine());
            // Prompt and read the Position of the HockeyPlayer
            Console.Write("Enter the player position (C,LW,RW,D,G): ");
            player1.Position = Console.ReadLine();
            // Add the HockeyPlayer object to playerList
            playerList.Add(player1);
            playerCount = playerList.Count;

            return playerCount;
        }

        /// <summary>
        /// Display information about each HockeyPlayer in playerList
        /// </summary>
        /// <param name="playerList">The list of hocker players</param>
        static void DisplayHockerPlayers(List<HockeyPlayer> playerList)
        {
            foreach(
                HockeyPlayer    // Collection element data type
                singlePlayer    // Variable name you assigned represent a element in the collection
                in              // reserve keyword
                playerList      // Collection of objects/values to iterate through
                )
            {
                Console.WriteLine($"Player Name: {singlePlayer.Name}");
                Console.WriteLine($"Player Number: {singlePlayer.Number}");
                Console.WriteLine($"Player Position: {singlePlayer.Position}");
            }
        }

        static void WriteToFile(List<HockeyPlayer> playerList, string outputFilePath)
        {
            StreamWriter writer = new StreamWriter(outputFilePath); // Create a new file to write to
            foreach(HockeyPlayer singlePlayer in playerList)
            {
                writer.Write(singlePlayer.Name);
                writer.Write(",");
                writer.Write(singlePlayer.Number);
                writer.Write(",");
                writer.WriteLine(singlePlayer.Position);
            }
            writer.Close();

        }

        static void DisplayMainMenu()
        {
            Console.WriteLine("1. Add New Hockey Player");
            Console.WriteLine("2. Display all Hockey Player");
            Console.WriteLine("3. Save list to a file");
            Console.WriteLine("4. Load list from a file");
            Console.WriteLine("0. Quit program");
        }
        static void Main(string[] args)
        {
            // Declare and create a new List of HockeyPlayer
            List<HockeyPlayer> playerList = new List<HockeyPlayer>();
            string outputFilePath = @"C:\temp\hockey-players.csv";

            int menuChoice; // To hold menu choice
            const int QuitProgramChoice = 0;
            int playerCount = 0;

            do
            {
                DisplayMainMenu();
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice) 
                {
                    case 1:
                        playerCount = AddHockeyPlayer(playerList);
                        Console.WriteLine($"There are currently {playerCount} players.");
                        break;
                    case 2:
                        DisplayHockerPlayers(playerList);
                        break;
                    case 0:
                        Console.WriteLine("Good-bye");
                        break;
                    default:
                        Console.WriteLine("Invalid input value. Try again");
                        break;
                }
            } while (menuChoice != QuitProgramChoice);

        }
    }
}
