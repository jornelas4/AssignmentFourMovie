using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentFourMovie
{
    public class Show : Film{
        public int Season { get; set; } 
        public int Episode { get; set; } 
        public string[] Writers { get; set; }
        public static string File = "show.csv";

        public override void Read()
        {
            Console.WriteLine("How many movies do you want to display? ");
            int numberOfShows = Int32.Parse(Console.ReadLine());
            
            StreamReader reader = new StreamReader(File);

            for(int i = 0; i < numberOfShows + 1 ; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);    
            }
            reader.Close();
        }

        public override void Write()
        {
            ItemID = getLastID() + 1;
            StreamWriter sw = new StreamWriter(File, true);

            Console.WriteLine("Please enter a new title: ");
            string showTitle = Console.ReadLine();

            Console.WriteLine("Please enter a new season: ");
            int season = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a new episode: ");
            int episode = Int32.Parse(Console.ReadLine()) ;

            var writers = new List<string>();
            string writer;
            string option;

            do
            {
                Console.WriteLine("Please add film writer: ");
                writer = Console.ReadLine();
                writers.Add(writer);
                Console.WriteLine("Would you like to write to file: (Y/N)");
                option = Console.ReadLine().ToUpper();
            } while (option == "Y");
            
            string newWriters =  string.Join("|", writers); 
            sw.WriteLine("{0},{1},{2},{3},{4}", ItemID, showTitle, season, episode, newWriters);
            sw.Close();
        }

        public override int getLastID()
        {
            int lastID = 0;
                try
                {
                    string lastLine = System.IO.File.ReadLines(File).Last();
                    string[] lastLineSplit = lastLine.Split(',');
                    lastID = Convert.ToInt32(lastLineSplit[0]);
                    return lastID;
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Sorry file does not exist");
                }
                return lastID;
        }
    }

}