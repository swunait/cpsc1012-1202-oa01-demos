using System;

namespace AverageScoreArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to track the size of the array
            const int MaxNumScores = 100;

            // Declare a variable to track the number of elements in the array currently in use
            int logicalArraySize;
            // Declare a variable to store the sum of all elements in the array
            double sum = 0;
            // Declare and create a new array of double of size MaxNumScores
            double[] scoreArrary = new double[MaxNumScores];

            // Prompt for the number of elements to enter:
            Console.WriteLine("Enter the number of scores: ");
            logicalArraySize = int.Parse(Console.ReadLine());

            // Prompt and read in the scores
            Console.WriteLine("Enter the scores: ");
            for (int index = 0; index < logicalArraySize; index++)
            {
                scoreArrary[index] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            // Sum the total of all elements in the array
            for (int index = 0; index < logicalArraySize; index++)
            {
                //sum = sum + scoreArrary[index];
                sum += scoreArrary[index];
            }
            // Calculate and display the average score
            double averageScore = sum / logicalArraySize;
            Console.WriteLine($"The average is {averageScore}");
            
        }
    }
}

