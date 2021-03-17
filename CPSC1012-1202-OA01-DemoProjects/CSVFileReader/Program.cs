using System;

using System.IO;    // for StreamReader class

namespace CSVFileReader
{
    class Program
    {
        static int LoadDataIntoParallelArrays(string[] dateReportedArray, string[] ahsZoneArray, string[] caseStatusArray)
        {
            int recordsRead = 0;    // number of records read from the CSV file
            string csvFilePath = @"C:\temp\covid19dataexport.csv";

            // Create a StreamReader object for reading from a text file
            StreamReader reader = new StreamReader(csvFilePath);

            // Skip the first line which contains column headings
            reader.ReadLine();

            // Read from the CSV file one line at a time
            String lineText;
            while ((lineText = reader.ReadLine()) != null)
            {
                // Convert the lineText into an array of values separated by a comma
                string[] lineValues = lineText.Split(',');
                string dateReported = lineValues[1];
                //dateReported = dateReported.Replace('"', '\0');
                string ahsZone = lineValues[2];
                //ahsZone = ahsZone.Replace('"', '\0');
                string status = lineValues[5];
                //status = status.Replace('"', '\0');

                dateReportedArray[recordsRead] = dateReported;
                ahsZoneArray[recordsRead] = ahsZone;
                caseStatusArray[recordsRead] = status;

                // Increment recordsRead
                recordsRead += 1;
            }
            // Close the reader 
            reader.Close();
            return recordsRead;
        }

        // Determine the total number of records where the caseStatus is "Active" for a given ahsZone
        static int TotalActiveCasesByZone(string ahsZone, string[] ahsZoneArray, string[] caseStatusArray, int recordCount)
        {
            int activeCaseCount = 0;

            for (int index = 0; index < recordCount; index++)
            {
                // Check if the current ahsZoneArray element matches ahsZone and caseStatusArray element is Active
                // then increment activeCaseCount by one
                if (ahsZoneArray[index].ToUpper().Contains(ahsZone.ToUpper())
                    && caseStatusArray[index].ToUpper().Contains("Active".ToUpper()))
                {
                    activeCaseCount += 1;
                }
            }

            return activeCaseCount;
        }

        // Determine the total number of active cases for a single day for a given zone
        static int TotalActiveCaseByDate(string dateReported, string ahsZone,
            string[] dateReportedArray, string[] ahsZoneArray, string[] caseStatusArray,
            int recordCount)
        {
            int activeCaseCount = 0;

            for (int index = 0; index < recordCount; index++)
            {
                if (dateReportedArray[index].Contains(dateReported) &&
                    ahsZoneArray[index].ToUpper().Contains(ahsZone.ToUpper())
                    && caseStatusArray[index].ToUpper().Contains("Active".ToUpper()))
                {
                    activeCaseCount += 1;
                }
            }

            return activeCaseCount;
        }


        // This programs reads from a CSV file that contains COVID-19 status
        // and display its contents to the console screen.
        static void Main(string[] args)
        {
            const int MaxRecords = 150000;       // The physical size of the arrays
            // Declare and create 3 parallel arrays
            string[] dateReportedArray = new string[MaxRecords];
            string[] ahsZoneArray = new string[MaxRecords];
            string[] caseStatusArray = new string[MaxRecords];
            // Load data into the 3 parallel arrays and track the number of records read
            int recordCount = LoadDataIntoParallelArrays(dateReportedArray, ahsZoneArray, caseStatusArray);
            // Prompt and read in a ahsZone to search for
            Console.Write("Enter the AHS Zone (Edmonton Zone, Calgary Zone, etc): ");
            string queryAhsZone = Console.ReadLine();
            // Find the active case count for the queryAhsZone
            int activeCaseCount = TotalActiveCasesByZone(queryAhsZone, ahsZoneArray, caseStatusArray, recordCount);
            // Display the active case count to the user
            Console.WriteLine($"There are currently {activeCaseCount} Active cases in the {queryAhsZone} ");
            // Prompt and read in a date to query
            Console.Write("Enter the date (yyyy-MM-dd) to query:");
            string queryDate = Console.ReadLine();
            int dailyActiveCaseCount = TotalActiveCaseByDate(queryDate, queryAhsZone, dateReportedArray, ahsZoneArray, caseStatusArray, recordCount);
            // Display the total actives for a given single day
            Console.WriteLine($"There are {dailyActiveCaseCount} on {queryDate} for {queryAhsZone}");


        }
    }
}