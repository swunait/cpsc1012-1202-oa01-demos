using System;

namespace Bar1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the maximum number of bars supported
            const int MaxBars = 10;
            // Define the character symbol for print in the bar
            const char BarSymbol = '*';
            // Declare and create a new array of int to track how characters to print for each bar
            int[] amountOfBars = new int[MaxBars];
            // Declare a variable to track the number of bars to print
            int numberOfBars = 0;

            // Prompt for the number of bars
            Console.Write("Enter the number of bars to print:");
            numberOfBars = int.Parse(Console.ReadLine());

            // Prompt for the number of characters to print for each bar
            Console.Write("Enter the number of characters (up to 50) to print for each bar, one line at a time: ");
            for (int index = 0; index < numberOfBars; index++)
            {
                amountOfBars[index] = int.Parse(Console.ReadLine());
            }

            // Print the heading 0...50
            for (int count = 0; count <= 50; count++)
            {
                if (count == 0 || count == 50)
                {
                    Console.Write(count);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

            // Print the heading |-----------|...|---------|
            for (int count = 0; count <= 50; count++)
            { 
                if (count % 10 == 0)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();

            // Print the characters for each bar
            for (int currentBarIndex = 0; currentBarIndex < numberOfBars; currentBarIndex++)
            {
                Console.Write("|");
                for (int index = 0; index < amountOfBars[currentBarIndex]; index++)
                {
                    Console.Write(BarSymbol);
                }
                Console.WriteLine();
            }

        }
    }
}
