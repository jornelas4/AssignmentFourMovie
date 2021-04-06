using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace AssignmentFourMovie
{
    public class Video : Film{
        public string Format { get; set; } 
        public int Length { get; set; } 
        public int[] Regions { get; set; } 
        public static string File = "video.csv";

        public override void Read()
        {
            Console.WriteLine("How many movies would you like to output? ");
            int numberOfVideos = Int32.Parse(Console.ReadLine());
            
            StreamReader reader = new StreamReader(File);

            for(int i = 0; i < numberOfVideos + 1 ; i++)
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
            string videoTitle = Console.ReadLine();

            Console.WriteLine("Please enter a new season: ");
            string format = Console.ReadLine();

            Console.WriteLine("Please enter a new episode: ");
            int lenght = Int32.Parse(Console.ReadLine()) ;

            var regions = new List<string>();
            string region;
            string option;

            do
            {
                Console.WriteLine("Please Add region: ");
                region = Console.ReadLine();
                regions.Add(region);
                Console.WriteLine("Would you like to add region to file: (Y/N)");
                option = Console.ReadLine().ToUpper();
            } while (option == "Y");
            
            string newRegions =  string.Join("|", regions); 
            sw.WriteLine("{0},{1},{2},{3},{4}", ItemID, videoTitle, format, lenght, newRegions);
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