using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentFourMovie
{
    public class Movie : Film{
        public string Genres { get; set;}
        private static string File = "movie.csv";
        
        // Read Movies
        public override void Read()
        {
            Console.WriteLine("How many movies do you want to display? ");
            int numberOfMovies = Int32.Parse(Console.ReadLine());
            
            StreamReader reader = new StreamReader(File);

            for(int i = 0; i < numberOfMovies + 1 ; i++)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);    
            }
            reader.Close();
        }
        
        // Add Movie
        public override void Write()
        {
            ItemID = getLastID() + 1;
            StreamWriter sw = new StreamWriter(File, true);

            Console.WriteLine("Please enter a new title: ");
            string movieTitle = Console.ReadLine();

            var genres = new List<string>();
            string genre;
            string option;

            do
            {
                Console.WriteLine("Please add genres: ");
                genre = Console.ReadLine();
                genres.Add(genre);
                Console.WriteLine("Would you like to add a genre: (Y/N)");
                option = Console.ReadLine().ToUpper();
            } while (option == "Y");
            
            string newGenres =  string.Join("|", genres); 
            sw.WriteLine("{0},{1},{2}", ItemID, movieTitle, newGenres);
            sw.Close();
        }

        // Auto Increment ID
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