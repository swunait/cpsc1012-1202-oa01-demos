using System;

namespace TestPassByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1;
            int secondNumber = 2;
            Console.WriteLine($"Before invoking the Swap method, firstNumber is {firstNumber} and secondNumber is {secondNumber}");
            Swap(ref firstNumber, ref secondNumber);
            Console.WriteLine($"After invoking the Swap method, firstNumber is {firstNumber} and secondNumber is {secondNumber}");

        }
        static void Swap(ref int num1, ref int num2)
        {
            Console.WriteLine("\tInside the Swap method");
            Console.WriteLine($"\t\tBefore swapping, num1 is {num1} and num2 is {num2}");
            // Swap num1 with num2
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"\t\tAfter swapping, num1 is {num1} and num2 is {num2}");
        }
    }
}
