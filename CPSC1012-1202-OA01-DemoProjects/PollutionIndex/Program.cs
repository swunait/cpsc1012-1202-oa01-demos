using System;

namespace PollutionIndex
{
    class Program
    {
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
            //if ___________________
            //{
            //    Console.WriteLine("Hazardous condition");

            //}    
            //___________________
            //{
            //    Console.WriteLine("Non-hazardous condition");
            //}

        }
    }
}
