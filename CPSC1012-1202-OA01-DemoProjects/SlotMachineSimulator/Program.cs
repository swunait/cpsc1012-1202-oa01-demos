using System;

namespace SlotMachineSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize an array of fruit names
            string[] fruitNames = {
                "Cherries",
                "Oranges",
                "Plums",
                "Bells",
                "Melons",
                "Bars"
            };
            const int totalSlots = 3;
            int[] slotValues = new int[totalSlots];
            Random rand = new Random();
            // generate values for each slot in the machine 
            for (int index = 0; index < totalSlots; index += 1)
            {
                slotValues[index] = rand.Next(0, fruitNames.Length);
            }
            // simulate spinning and display each slot value
            for (int index = 0; index < totalSlots; index += 1)
            {
                Console.Beep();
                int fruitIndex = slotValues[index];
                string fruitName = fruitNames[fruitIndex];
                Console.Write($"{fruitName} ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
            // determine how many fruit names match

        }
    }
}
