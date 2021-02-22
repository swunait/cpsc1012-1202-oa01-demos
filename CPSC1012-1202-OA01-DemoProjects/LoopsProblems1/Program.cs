using System;

namespace LoopsProblems1
{
    class Program
    {

        // Define a void method name Question1 with no input parameters
        static void Question1()
        {
            int mySquare;
            int number;
            int sum = 0; // set accumulator to 0
            Console.WriteLine("Please enter an integer: ");
            mySquare = int.Parse(Console.ReadLine());

            for (number = 1; number <= mySquare; number++)
            {
                sum = sum + number * number; // add the sum on top of each loop, (squared number), the current sum + the squared number = the new sum
                Console.Write($"{number}x{number} ");
                if (number < mySquare)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine($"= {sum}");
        }

        // Define a void method anemd Question2 with no input parameters
        static void Question2()
        {
            const int SentinelValue = 0;
            int userNumber = 1;
            //int userAge;
            //int i = 0;
            int count = 0;
            int sum = 0;    // accumulator
            double userAverageAge = 0;

            while (userNumber != SentinelValue)
            {
                Console.WriteLine("Please enter a age (0 to quit): ");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber != SentinelValue)
                {
                    sum += userNumber;
                    count += 1;
                }
            }
            if (count > 0)
            {
                userAverageAge = sum / count;
                Console.WriteLine($"Average age is {userAverageAge}");
            }
            else
            {
                Console.WriteLine("There were no age entered to calcualte the average.");
            }

        }

        static void Question3()
        {
            int userInput,
                remainderOfUserInput;
            Console.WriteLine("Please input a number to be displayed in a reverse column: ");
            userInput = int.Parse(Console.ReadLine());

            while (userInput > 0)
            {
                remainderOfUserInput = userInput % 10;
                Console.WriteLine($"{remainderOfUserInput}");
                userInput /= 10;
            }
        }

        static void Main(string[] args)
        {
            // Call the Question1 void method
            // Question1();
            // Question2();
            Question3();

        }
    }
}
