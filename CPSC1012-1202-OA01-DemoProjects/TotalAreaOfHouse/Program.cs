using System;

using RectangleDemo;

namespace TotalAreaOfHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the total area of a house with one kitchen, one den, and one bedroom.
            Rectangle kitchen = new Rectangle(10, 20);
            Rectangle den = new Rectangle(10, 10);
            Rectangle bedroom = new Rectangle(15, 15);
            double totalArea = kitchen.Area() + den.Area() + bedroom.Area();


        }
    }
}
