/*  Purpose: Determine if a storm is a hurricane based on its wind speed.
 *  
 *  Input:   Wind speed in miles per hour
 *  
 *  Process: The category of the hurrican use determined by the table below.
 *  
 *          Storm Classifcation     Wind Speed
 *          --------                -----------------------------
 *          Not a hurricane         < 74
 *          Catetory 1              74 - 95
 *          Catetory 2              96 - 110
 *          Catetory 3              111 - 130
 *          Catetory 4              131 - 155
 *          Catetory 5              156+
 *          
 * Output:  Storm classifiction         
 *          
 * 
 * */
using System;

namespace HoldOnToYourHats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for windSpeed (int) and stormClassification (string)
            int windSpeed;  // in miles per hour
            string stormClassification;

            // Prompt and read the windSpeed
            Console.Write("Enter the wind speed in miles per hour: ");
            windSpeed = int.Parse(Console.ReadLine());

            // Lookup in table the classification of the storm based on the windSpeed
            // Check if not a hurricane
            if (windSpeed <= 74)
            {
                stormClassification = "Not a hurricane";
            }
            // Check if it is a Category 1 hurricane
            else if (windSpeed <= 95)
            {
                stormClassification = "Category 1";
            }
            // Check if it is a Category 2 hurricane
            else if (windSpeed <= 110)
            {
                stormClassification = "Category 2";
            }
            // Check if it is a Category 3 hurricane
            else if (windSpeed <= 130) 
            {
                stormClassification = "Category 3";
            }
            // Check if it is a Category 4 hurriance
            else if (windSpeed <= 155)
            {
                stormClassification = "Category 4";
            }
            // Must be a Category 5
            else 
            {
                stormClassification = "Category 5";
            }

            // Display the storm classification
            Console.WriteLine($"Wind speed of {windSpeed} miles/hour is classified as {stormClassification}");

        }
    }
}
