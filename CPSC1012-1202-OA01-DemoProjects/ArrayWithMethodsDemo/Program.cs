using System;

namespace ArrayWithMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate 5 random numbers between 1 and 10
            int[] numberArray1 = GenerateNumbers(1, 10, 5);
            // Display the array contents of numberArray1
            DisplayNumbers(numberArray1);
            // Generate 3 random numbers between 18 and 65
            int[] numberArray2 = GenerateNumbers(18, 65, 3);
            // Display the array contents of numberArray2
            DisplayNumbers(numberArray2);
        }

        // Create a new int array of size numberCount
        // and generate numberCount of numbers between minValue and maxValue
        static int[] GenerateNumbers(int minValue,
                                        int maxValue,
                                        int numberCount)
        {
            int[] numberArray = new int[numberCount];
            Random rand = new Random();
            for (int index = 0; index < numberCount;)
            {
                int randomNumber = rand.Next(minValue, maxValue + 1);
                bool duplicate = IsNumberInArray(numberArray, randomNumber);
                if (!duplicate)
                {
                    numberArray[index] = randomNumber;
                    index += 1;
                }
            }
            // sort numberArray ascending
            SelectionSort(numberArray);
            return numberArray;
        }
        static void DisplayNumbers(int[] numberArray)
        {
            // Display the value of element in numberArray
            // seperate each value with one blank space
            for (int index = 0; index < numberArray.Length; index++)
            {
                Console.Write(numberArray[index] + " ");
            }
            Console.WriteLine();
        }

        static bool IsNumberInArray(int[] array, int number)
        {
            bool inArray = false;
            // perform a sequential search and stop once found
            for (int index = 0; index < array.Length; index += 1)
            {
                if (array[index] == number)
                {
                    inArray = true;
                    // stop iterating through loop
                    index = array.Length;
                    //break;
                }
            }
            return inArray;
        }

        static void SelectionSort(int[] array)
        {
            for (int outerIndex = 0; outerIndex < array.Length - 1; outerIndex += 1)
            {
                // Find the smallest in the array[outerIndex to array.Length-1]
                int currentSmallestValue = array[outerIndex];
                int currentSmallestIndex = outerIndex;

                for (int innerIndex = outerIndex + 1; innerIndex < array.Length; innerIndex += 1)
                {
                    if (currentSmallestValue > array[innerIndex])
                    {
                        currentSmallestValue = array[innerIndex];
                        currentSmallestIndex = innerIndex;
                    }
                }

                // Swap numbers
                if (currentSmallestIndex != outerIndex)
                {
                    array[currentSmallestIndex] = array[outerIndex];
                    array[outerIndex] = currentSmallestValue;
                }
            }
        }
    }
}
