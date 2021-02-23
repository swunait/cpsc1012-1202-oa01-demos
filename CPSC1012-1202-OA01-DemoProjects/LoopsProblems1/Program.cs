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

        static void Question21()
        {
            int currentDayOfMonth; // loop control variable
            int currentDayOfWeek = 0;
            int daysInMonth;
            string dayOfWeek = "";
            //int days = 0;

            Console.WriteLine("How many days are in the month? ");
            daysInMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Which day of the week does the first of the month land on? ");
            dayOfWeek = Console.ReadLine();
            int firstDayOfWeek = 0;
            switch (dayOfWeek.ToLower())
            {
                case "sun":
                    firstDayOfWeek = 0;
                    break;
                case "mon":
                    firstDayOfWeek = 1;
                    break;
                case "tue":
                    firstDayOfWeek = 2;
                    break;
                case "wed":
                    firstDayOfWeek = 3;
                    break;
                case "thu":
                    firstDayOfWeek = 4;
                    break;
                case "fri":
                    firstDayOfWeek = 5;
                    break;
                case "sat":
                    firstDayOfWeek = 6;
                    break;
                default:
                    break;
            }

            bool startPrintingDayOfMonth = false;
            Console.WriteLine($"{"Sun",5}{"Mon",5}{"Tue",5}{"Wed",5}{"Thu",5}{"Fri",5}{"Sat",5}");
            for (currentDayOfMonth = 1; currentDayOfMonth <= daysInMonth; )
            {
                // Determine if we reached the first day of the week of the month
                if (!startPrintingDayOfMonth && currentDayOfWeek == firstDayOfWeek)
                {
                    startPrintingDayOfMonth = true;
                }

                if (!startPrintingDayOfMonth)
                {
                    Console.Write("     ");
                }
                else
                {
                    Console.Write($"{currentDayOfMonth,5}");
                    currentDayOfMonth++;
                }
                currentDayOfWeek++;
                if (currentDayOfWeek > 6)
                {
                    currentDayOfWeek = 0;
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Call the Question1 void method
            // Question1();
            // Question2();
            // Question3();
            const int SentinelValue = 0;
            int menuInput;

            do
            {
                Console.WriteLine("1. Question 1");
                Console.WriteLine("2. Question 2");
                Console.WriteLine("3. Question 3");
                Console.WriteLine("4. Question 2.1");
                Console.WriteLine("0. Exit Program");
                menuInput = int.Parse(Console.ReadLine());
                switch (menuInput)
                {
                    case 1:
                        Question1();
                        break;
                    case 2:
                        Question2();
                        break;
                    case 3:
                        Question3();
                        break;
                    case 4:
                        Question21();
                        break;
                    case 0:
                        Console.WriteLine("Good-bye");
                        break;
                    default:
                        Console.WriteLine("Error! Invalid input value. Enter a value between 0-3.");
                        break;
                }

            } while (menuInput != SentinelValue);

        }
    }
}
