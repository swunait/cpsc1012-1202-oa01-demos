using System;

using System.IO;    // for StreamReader and StreamWrite classes
namespace NhlPlayers
{
    class Program
    {
        static int ReadPlayerData(String filePath, string[] playerNames, int[] playerPoints)
        {
            int playerCount = 0;    // The number of records read from the file
            try
            {
                // Construct a StreamReader instance for reading from a text file
                StreamReader reader = new StreamReader(filePath);
                string lineText;
                int index = 0;
                // Read one line at time until we reach the end of the file (EOF)
                while ( (lineText = reader.ReadLine()) != null)
                {
                    // Split the line values into an array of value 
                    string[] lineArray = lineText.Split(',');
                    string name = lineArray[0];
                    int point = int.Parse(lineArray[1]);
                    playerNames[index] = name;
                    playerPoints[index] = point;
                    index++;
                    playerCount++;
                }
                reader.Close();
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from {filePath} with exception {ex.Message}");
            }
            return playerCount;
        }

        static void PrintPlayers(string[] playerNames, int[] playerPoints, int playerCount)
        {
            Console.WriteLine($"{"Player Name", -20} {"Player Points",10}");
            for (int index = 0; index < playerCount; index++)
            {
                Console.WriteLine($"{playerNames[index], -20}  {playerPoints[index], 10}");
            }
        }

        static int IndexOfPlayerWithMostPoints(int[] playerPoints, int playerCount)
        {
            int indexOfMostPoints = 0;
            int highestPoints = playerPoints[0];    // Assume the first element contains the highest
            for (int index = 1; index < playerCount; index++)
            {
                // Compare current point with highest point
                if (playerPoints[index] > highestPoints)
                {
                    // Assign the new highest point
                    highestPoints = playerPoints[index];
                    // Assign the index of the highest point
                    indexOfMostPoints = index;
                }
            }

            return indexOfMostPoints;
        }

        static void Main(string[] args)
        {
            // Declare a varible for the maximum number of players per team
            const int MaxPlayers = 25;
            // Declare and create a new array of player name and player points
            string[] playNames = new string[MaxPlayers];
            int[] playerPoints = new int[MaxPlayers];
            int playerCount = 0;
            //string filePath = "C:\\temp\\players.csv";
            string filePath = @"C:\temp\players.csv";   // @ prefix is to define a literal string where there are no special characters

            playerCount = ReadPlayerData(filePath, playNames, playerPoints);

            PrintPlayers(playNames, playerPoints, playerCount);

            // Find and print the player with the most points
            int mostPointsIndex = IndexOfPlayerWithMostPoints(playerPoints, playerCount);
            Console.WriteLine($"The player with the most points is: {playNames[mostPointsIndex]} with {playerPoints[mostPointsIndex]} ");

        }
    }
}
