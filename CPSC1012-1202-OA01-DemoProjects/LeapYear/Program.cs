/* Purpose: Determine if a year is a leap year or not.
 * 
 * Input:   year
 * 
 * Process: A year is a leap year if the ONE of the following conditions is true:
 *          1) year is divisble by 4 AND not by 100
 *          2) year is divisble by 400
 * 
 * Output: A message indicating if the yar is a leap year or not
 * 
 * */
using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read in the year
            Console.WriteLine("This program determines if a year is a leap year");
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // Determine if the year is a leap year 
            bool isLeapYear = false;    // Assume it is not a leap year
            // Condition 1: a leap year is divisble by 4 AND not by 100
            if ((year % 4 == 0) && !(year % 100 == 0))
            {
                isLeapYear = true;
            }
            else if ((year % 400) == 0)
            { // Condition 2: year is divisble by 400
                isLeapYear = true;
            }
            // Output a message indicating if the year is a leap year
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is NOT a leap year.");
            }
        }
    }
}
