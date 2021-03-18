using System;

using System.Threading; // for Thread class

namespace SlotMachineSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize an array of fruit names
            string[] fruitNames = {
                "Cherries",     // index 0
                "Oranges",      // index 1
                "Plums",        // index 2
                "Bells",        // index 3
                "Melons",       // index 4
                "Bars"          // index 5
            };

            const int TotalSlots = 3;
            int[] slotValues = new int[TotalSlots];
            Random rand = new Random();
            // generate values for each slot in the machine 
            for (int index = 0; index < TotalSlots; index += 1)
            {
                slotValues[index] = rand.Next(0, fruitNames.Length);
            }
            // simulate spinning and display each slot value
            for (int index = 0; index < TotalSlots; index += 1)
            {
                //Console.Beep();
                int fruitIndex = slotValues[index];
                string fruitName = fruitNames[fruitIndex];
                Console.Write($"{fruitName} ");
                Thread.Sleep(3000);    // Pauses the program for 3000 milliseconds or 3 seconds
            }
            Console.WriteLine();
            // determine how many fruit names match

        }
    }
}
