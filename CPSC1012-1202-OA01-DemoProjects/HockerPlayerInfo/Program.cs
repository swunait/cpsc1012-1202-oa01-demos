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
            if (playerList.Count == 0)
            {
                Console.WriteLine("There are currently no hockey players");
            }
            else
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

            
        }

        /// <summary>
        /// Read the CSV file located in inputFilePath and for each line in the file
        /// create a HockerPlayer object and set the properties using values from the line.
        /// Add the new HockerPlayer object to the list
        /// </summary>
        /// <param name="playerList">List of hockery players</param>
        /// <param name="inputFilePath">Locations of CSV file</param>
        static void ReadFromFile(List<HockeyPlayer> playerList, string inputFilePath)
        {
            // Open the file for reading
            StreamReader reader = new StreamReader(inputFilePath);
            string lineText = null;
            int counter = 0;    // To track number of records read
            // Read one line at a time until end of file is reached
            do
            {
                // Read the current line from the file
                lineText = reader.ReadLine();
                // If not EOF then extract the field values from the line
                if (lineText != null)
                {
                    // Increment counter
                    counter++;
                    // Split the line into an array of values separated by the delimiter char comma
                    string[] lineArray = lineText.Split(",");
                    // Create a new HockeyPlayer object 
                    HockeyPlayer currentHockerPlayer = new HockeyPlayer();
                    // Assign the Name of the hockey player using the first value in the array
                    currentHockerPlayer.Name = lineArray[0];
                    // Assign the Number of the hockey player using the second value in the array
                    currentHockerPlayer.Number = int.Parse(lineArray[1]);
                    // Assign the Position of the hockey player using the third value in the array
                    currentHockerPlayer.Position = lineArray[2];
                    // Add the currentHockeyPlayer to playerList
                    playerList.Add(currentHockerPlayer);
                }
            } while (lineText != null);
            reader.Close();
            Console.WriteLine($"Successfully added {counter} records.");

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
            Console.WriteLine($"Successfully wrote data to ${outputFilePath}");
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
            string dataFilePath = @"C:\temp\hockey-players.csv";

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
                    case 3:
                        WriteToFile(playerList, dataFilePath);
                        break;
                    case 4:
                        ReadFromFile(playerList, dataFilePath);
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
