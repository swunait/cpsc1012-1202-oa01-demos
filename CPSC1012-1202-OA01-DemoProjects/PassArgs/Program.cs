using System;

namespace PassArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("I am passing values to DisplayValue.");
            DisplayValue(5); // Pass 5
            DisplayValue(x); // Pass 10
            DisplayValue(x * 4); // Pass 40
            DisplayValue(int.Parse("700")); // Pass 700
            Console.WriteLine("That's all");
        }

        static void DisplayValue(int num)
        {
            Console.WriteLine("The value is " + num);
        }
    }
}
