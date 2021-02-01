using System;

namespace PollutionIndex
{
    class Program
    {
        // Averages input pollution level readings and compare to a cutoff
        // value for possible hazardous condition. Display a warning message
        // if the index is greater than or equal to the given cutoff value.
        static void Main(string[] args)
        {
            const double CUTOFF = 50.0;      // Cutoff for hazardous condition

            double level1, level2, level3,      // Pollution level readings
                   index;                       // Average of readings

            Console.WriteLine("Enter 3 pollution level readings: ");
            level1 = double.Parse(Console.ReadLine());
            level2 = double.Parse(Console.ReadLine());
            level3 = double.Parse(Console.ReadLine());

            index = (level1 + level2 + level3) / 3;

            // Check for hazardous condition.
            if (index >= CUTOFF )
            {
                Console.WriteLine("Hazardous condition");

            }
            else
            {
                Console.WriteLine("Non-hazardous condition");
            }

        }
    }
}
