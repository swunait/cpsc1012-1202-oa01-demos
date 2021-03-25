using System;

namespace RectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that creates a Rectangle object with a width of 28 and
            //length of 40. Display the width, length, area, perimeter, and diagonal the
            //rectangle object.

            // Create a new Rectangle object named rectangle1
            Rectangle rectangle1 = new Rectangle();
            // Change the width of the rectangle to 28
            rectangle1.Width = 28;
            // Change the length of the rectangle to 40
            rectangle1.Length = 40;

            // Create a new Rectangle object named rectangle2 with a width of 28 and length of 40
            //Rectangle rectangle2 = new Rectangle(40, 28);

            // Display the width, height, area, permieter, and diagonal of rectangle1
            Console.WriteLine($"The rectangle width is {rectangle1.Width}");
            Console.WriteLine($"The rectangle length is {rectangle1.Length}");
            Console.WriteLine($"The rectangle area is {rectangle1.Area()}");
            Console.WriteLine($"The rectangle permimeter is {rectangle1.Perimeter()}");
            Console.WriteLine($"The rectangle diagonal is {rectangle1.Diagonal()}");

        }
    }
}
