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
            // Prompt and read in the rectangle symbols, the number of rows, and columns
            Console.Write("Enter the symbol to print the rectangle with: ");
            char rectangleSymbol = char.Parse(Console.ReadLine());
            //Console.Write("Enter the number of rows for the rectangle: ");
            //int rows = int.Parse(Console.ReadLine());
            int rows = PromptForInteger("Enter the number of rows for the rectangle: ");

            //Console.Write("Enter the number of columns for the rectangle: ");
            //int columns = int.Parse(Console.ReadLine());
            int columns = PromptForInteger("Enter the number of columns for the rectangle: ");

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
