using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up app reading and writing capability
            using (var streamReader = new StreamReader("../../games.csv"))
            using (var streamWriter = new StreamWriter("../../reorder.csv"))
            using (var reader = new CsvReader(streamReader))
            using (var writer = new CsvWriter(streamWriter))
            {

                //Generate an in-memory list containing the rows of CSV data
                reader.Configuration.RegisterClassMap<RowMap>();
                List<Row> games = reader.GetRecords<Row>()
                    .ToList();

                //User Interface
                Console.WriteLine("Data stored in an in-memory list: Sort by...\n");
                Console.WriteLine("\t1: Number of Turns");
                Console.WriteLine("\t2: White rating");
                Console.WriteLine("\t3: Black rating");
                Console.WriteLine("\t4: Opening Name");
                Console.WriteLine("\t5: Exit");

                //Take user input
                int caseSwitch;
                String input = Console.ReadLine();
                bool success = Int32.TryParse(input, out caseSwitch);

                //Check that input is valid
                while (!success)
                {
                    Console.WriteLine(input + " is not a valid input. Please enter an integer between 1 and 5.");
                    input = Console.ReadLine();
                    success = Int32.TryParse(input, out caseSwitch);

                    if (caseSwitch < 1 || caseSwitch > 5)
                    {
                        success = false;
                    }
                }

                //execute user-specified instruction
                switch (caseSwitch - 1)
                {
                    case 0:
                        var turns = games.OrderBy(x => x.turns).ToList();
                        writer.WriteRecords(turns);
                        break;
                    case 1:
                        var whiteRating = games.OrderBy(x => x.white_rating).ToList();
                        writer.WriteRecords(whiteRating);
                        break;
                    case 2:
                        var blackRating = games.OrderBy(x => x.black_rating).ToList();
                        writer.WriteRecords(blackRating);
                        break;
                    case 3:
                        var opening = games.OrderBy(x => x.opening_name).ToList();
                        writer.WriteRecords(opening);
                        break;
                    case 4:
                        System.Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
