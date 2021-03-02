using System;

namespace DeepAndDeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am starting in Main.");
            Deep();
            Console.WriteLine("Now I am back in Main.");
        }
        static void Deep()
        {
            Console.WriteLine("I am now in Deep.");
            Deeper();
            Console.WriteLine("Now I am back in Deep.");
        }
        static void Deeper()
        {
            Console.WriteLine("I am now in Deeper.");
        }

    }
}
