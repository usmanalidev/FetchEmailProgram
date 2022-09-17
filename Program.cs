using System;
using System.Collections.Generic;
using System.IO;

namespace FetchEmailProgram
{
    class Program
    {
        //Default Folder
        static string fileName = @"C:\Users\Usman Ali\source\repos\FetchEmailProgram\bin\Debug\Data.txt";

        static void Main(string[] args)
        {
            FetchEmailFromFile();
            Console.ReadKey();
        }
        /// <summary>
        ///// Function used to fetch all emails from the file
        /// </summary>
        /// <returns></returns>
        private static void FetchEmailFromFile()
        {
            if (File.Exists(fileName))
            {
                // Read entire text file content in one string    
                string text = File.ReadAllText(fileName);
                Console.WriteLine(text);
            }

            if (File.Exists(fileName))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }

            if (File.Exists(fileName))
            {
                // Read file using StreamReader. Reads file line by line  
                using (StreamReader file = new StreamReader(fileName))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                }
            }
        }
    }
}
