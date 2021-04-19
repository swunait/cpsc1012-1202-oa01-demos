using System;

using System.IO;    // for StreamReader and StreamWriter

namespace HockeyTeamApp
{
    class Program
    {
        static void LoadHockeyTeam(HockeyTeam currentTeam, String inputFile)
        {
            // The input value will have the following format:
            // team name, division
            // player name, player number, player position
            // player name, player number, player position
            try
            {
                using (StreamReader reader = new StreamReader(inputFile))
                {
                    // The first line in the file contains the team name and division
                    string currentLine = reader.ReadLine();
                    // Convert the single into array of values separated by a comma
                    string[] currentLineArray = currentLine.Split(',');
                    // Set the team name and division 
                    currentTeam.TeamName = currentLineArray[0];
                    currentTeam.Division = (HockeyDivision) int.Parse(currentLineArray[1]);
                    // The remaining lines in the file contains the player info formatted:
                    // player name, number, position
                    while ( (currentLine = reader.ReadLine()) != null)
                    {
                        currentLineArray = currentLine.Split(',');
                        // Create a new HockeyPlayer to add to the Team
                        HockeyPlayer currentPlayer = new HockeyPlayer();
                        // Set the player name, number, and position
                        currentPlayer.FullName = currentLineArray[0];
                        currentPlayer.PrimaryNumber = int.Parse(currentLineArray[1]);
                        currentPlayer.Position = (PlayerPosition) int.Parse(currentLineArray[2]);
                        // Add the currentPlayer to the team
                        currentTeam.AddPlayer(currentPlayer);
                    }

                }
            } 
            catch(Exception e)
            {
                Console.WriteLine($"Error reading from {inputFile} with exception {e.Message}");
            }
        }

        static void DisplayTeamAndPlayers(HockeyTeam currentTeam)
        {
            // Write the code to display the team name, division, and the list of players
            // For each player display the full name, primary number, and position
            Console.WriteLine(currentTeam);
            Console.WriteLine($"{"Full Name",-25} {"Num", 5} {"Pos", 5}");
            foreach(HockeyPlayer currentPlayer in currentTeam.PlayerList)
            {
                Console.WriteLine(currentPlayer);
            }
        }

        static void SaveTeam(HockeyTeam currentTeam, string outputFile)
        {
            // Write the code to write to the outputFile the team name and divison on the first line
            // then for each player write their name, number, and position on a single line 
            try
            {
                using(StreamWriter writer = new StreamWriter(outputFile))
                {
                    // Write the team name and divison on the first line
                    writer.WriteLine($"{currentTeam.TeamName},{currentTeam.Division}");
                    // For each player write their full name, number, and position
                    foreach(HockeyPlayer currentPlayer in currentTeam.PlayerList)
                    {
                        writer.WriteLine($"{currentPlayer.FullName},{currentPlayer.PrimaryNumber},{currentPlayer.PrimaryNumber}");
                    }
                    Console.WriteLine($"Successfully saved data to {outputFile}");
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine($"Error reading from {outputFile} with exception {e.Message}");
            }

        }

        static void Main(string[] args)
        {
            HockeyTeam currentHockeyTeam = new HockeyTeam();
            string inputFile = @"c:\temp\oilers.csv";
            LoadHockeyTeam(currentHockeyTeam, inputFile);
            DisplayTeamAndPlayers(currentHockeyTeam);

            // Create a new Hocker player
            HockeyPlayer newHockeyPlayer = new HockeyPlayer();
            newHockeyPlayer.FullName = "Dominik Kahun";
            newHockeyPlayer.PrimaryNumber = 21;
            newHockeyPlayer.Position = PlayerPosition.C;
            // Add the new Hockey player to the team
            currentHockeyTeam.AddPlayer(newHockeyPlayer);

            string outputFile = @"c:\temp\flames.csv";
            SaveTeam(currentHockeyTeam, outputFile);

        }
    }
}
