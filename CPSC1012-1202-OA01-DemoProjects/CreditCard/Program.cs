using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary;          // Annual salary
            int creditRating;       // Credit ratign
                                    // Prompt and read in the user' annual salary
            Console.WriteLine("What is your annual salary?");
            salary = double.Parse(Console.ReadLine());
            // Prompt and read in the credit rating (1 through 10).
            Console.WriteLine("On a scale of 1 through 10, what is your credit rating?");
            Console.WriteLine("(10 = excellent. 1 = very bad)");
            creditRating = int.Parse(Console.ReadLine());
            // Determine whether the user qualifiers for the loan
            if (salary >= 20000 && creditRating >= 7)
            {
                Qualify();
            }
            else
            {
                NoQualify();
            }

        }

        // The Qualify method inform the user that he 
        // or she qualifies for the credit card
        static void Qualify()
        {
            Console.WriteLine("Congratulations! You qualify for the credit card!");
        }

        // The NoQualify method inform the user that he 
        // or she does not qualifies for the credit card
        static void NoQualify()
        {
            Console.WriteLine("I am sorry. You do not qualify for the credit card.");
        }

    }
}
