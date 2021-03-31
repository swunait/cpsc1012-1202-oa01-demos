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
            bool validInput = false;
            do
            {
                Console.Write("Enter the width of the rectangle: ");
                try
                {
                    // Assign the Width of the rectangle using the user input value
                    rectangle1.Width = double.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input value must be a number");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!validInput);

            validInput = false;     // reset validInput
            do
            {
                Console.Write("Enter the length of the rectangle: ");
                try
                {
                    rectangle1.Length = double.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Length must be a decimal value.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!validInput);

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
