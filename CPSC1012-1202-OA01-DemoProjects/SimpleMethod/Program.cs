using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Main method.");
            DisplayMessage();
            Console.WriteLine("Back in the Main method.");
        }

        static void DisplayMessage()
        {
            Console.WriteLine("Hello from the DisplayMessage method.");
        }
    }
}
