/**
 * Purpose: To calculate the total cost of a Internet package from an ISP.
 * 
 * Input:   service pacakge letter (A, B, C)
 *          hours (for package A or B)
 * 
 * Process: Lookup the following table for cost caluation
 * 
 *          Package     Cost
 *          -------     ------------------------
 *          A           $9.95/month for first 10 hours plus $2.00/hour after the first 10 hours
 *          B           $13.95/month for first 20 hours plus $1.00/hour after the first 20 hours
 *          C           $19.95/month
 *          
 * Output:  Total cost for a chose Internet package.
 * 
 * */

using System;

namespace InternetServiceProviderPackages
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variable for package letter (char)
            char packageLetter;

            // Prompt and read in te package letter
            Console.WriteLine("Please select one of the following packages:");
            Console.WriteLine("A - $9.95/month for first 10 hours plus $2.00/hour after the first 10 hours");
            Console.WriteLine("B - $13.95/month for first 20 hours pluse $1.00/hour after the first 20 hours");
            Console.WriteLine("C -  $19.95/month");
            packageLetter = char.Parse(Console.ReadLine());

            // Lookup the table for the total cost for the selected package
            // For package A and B declare variable for hours 
            // Prompt and read in the hours for package A and B
            switch( char.ToUpper(packageLetter) )
            {
                case 'A':   // Package A
                    {
                        // Prompt and read in the hours
                        int hours;
                        Console.WriteLine("Enter the hours you plan to use: ");
                        hours = int.Parse(Console.ReadLine());
                        // Declare variable for total cost
                        double totalCost = 9.95;
                        if (hours > 10)
                        {
                            double hourlyCost = 2 * (hours - 10);
                            totalCost = totalCost + hourlyCost;
                        }
                        // Display finalcost
                        Console.WriteLine($"Package A total cost is {totalCost}");
                    }
                    break;
                case 'B':   // Package B
                    {
                        // Prompt and read in the hours
                        int hours;
                        Console.WriteLine("Enter the hours you plan to use: ");
                        hours = int.Parse(Console.ReadLine());
                        // Declare variable for total cost
                        double totalCost = 13.95;
                        if (hours > 20)
                        {
                            double hourlyCost = (hours - 20);
                            totalCost = totalCost + hourlyCost;
                        }
                        // Display finalcost
                        Console.WriteLine($"Package B total cost is {totalCost}");
                    }
                    break;
                case 'C':   // Package C
                    {
                        Console.WriteLine("For package C, you monthly cost is $19.95/month.");
                    }
                    break;
                default:    // Invalid package selection
                    Console.WriteLine("Invalid menu choice - you must enter A, B, or C");
                    break;
            }

            // Display the total cost if a valid package letter is entered

        }
    }
}
