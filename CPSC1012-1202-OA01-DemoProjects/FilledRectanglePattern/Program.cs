/* Purpose:     Draw a filled-in rectangle with a user input character value with a user specified
 *              number of rows and columns for the rectangle
 *              
 * Inputs:      character symbol used to print the rectangle
 *              number for rows for charcters to print
 *              number of columns in each row to print
 *              
 * Process:     Setup a loop to print each row of the rectangle
 *                  Setup a loop to print each column of the rectangle
 * 
 * 
 * Output:     For example symbol = @, rows = 6, columns = 4
 *                1234 
 *              1 @@@@
 *              2 @@@@
 *              3 @@@@
 *              4 @@@@
 *              5 @@@@
 *              6 @@@@
 *              
 *                1234 
 *              1 @@@@
 *              2 @  @
 *              3 @  @
 *              4 @  @
 *              5 @  @
 *              6 @@@@
 * 
 *              
 * */
using System;

namespace FilledRectanglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read in the rectangle symbols, the number of rows, and columns
            Console.Write("Enter the symbol to print the rectangle with: ");
            char rectangleSymbol = char.Parse(Console.ReadLine());
            Console.Write("Enter the number of rows for the rectangle: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Etner the number of columns for the rectangle: ");
            int columns = int.Parse(Console.ReadLine());

            // Set a counter-controlled loop to print each row of the rectangle
            for (int currentRow = 1; currentRow <= rows; currentRow++)
            {
                // Set a counter-controlled loop to print each column of the rectangle
                for (int currentColumn = 1; currentColumn <= columns; currentColumn++)
                {
                    // Print one character on the current line
                    Console.Write(rectangleSymbol);
                }
                // Start a new line for the next row
                Console.WriteLine();
            }
        }
    }
}
