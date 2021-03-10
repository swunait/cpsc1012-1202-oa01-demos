using System;

namespace PollutionLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to track the physical size of the array
            const int PollutionArraySize = 6;
            // Declare a variable that references an array of int
            int[] pollutionLevel;
            // Create a new array of int of size PollutionArraySize and store the location in the pollutionLevel variable
            pollutionLevel = new int[PollutionArraySize];

            Console.WriteLine("Enter the six pollution level readings, one input per line: ");
            // Prompt the user for the pollution level for each element in the array
            for (int index = 0; index < pollutionLevel.Length; index++)
            {
                // Read the pollution level input and assign it to the current index location in the array
                pollutionLevel[index] = int.Parse(Console.ReadLine());
            }

            // Display each element in the pollutionLevel array with three values per line
            for (int index = 0; index < pollutionLevel.Length; index++)
            {
                // Print a new line after every 3 elements
                if (index % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{pollutionLevel[index]} ");
            }

        }
    }
}
