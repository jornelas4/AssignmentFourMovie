using System;


namespace AssignmentFourMovie
{
    public class Menu
    {
        public void TypeOfFilm(){
            Console.WriteLine("Please select the Film" + "\n");
            Console.WriteLine("1. Choose Movie");
            Console.WriteLine("2. Choose Show");
            Console.WriteLine("3. Choose Video");
            Console.WriteLine("4. Exit\n");
        }
        public void ExecuteMenu(){
            Console.WriteLine("Please select from the Menu " + "\n");
            Console.WriteLine("1. Review content");
            Console.WriteLine("2. Add new content");
            Console.WriteLine("3. Exit" + "\n");
        }
        public void MenuChoice() {
            int MenuChoice = 0;
            string preference;

            do{
                TypeOfFilm();
                MenuChoice = Int32.Parse(Console.ReadLine());
                switch(MenuChoice){
                    case 1: 
                        do{
                            ExecuteMenu();
                            MenuChoice = Int32.Parse(Console.ReadLine());
                            if(MenuChoice == 1){
                            Movie readMovies = new Movie();
                            do{
                                readMovies.Read();
                                System.Console.WriteLine("Would you like to review more movies? (Y/N)");
                                preference = Console.ReadLine().ToUpper();
                            }while(preference == "Y");
                            
                            }else if(MenuChoice == 2){
                            Movie addMovie = new Movie();
                            do{
                                addMovie.Write();
                                System.Console.WriteLine("Would you like to add more movies to the list? (Y/N)");
                                preference = Console.ReadLine().ToUpper();
                            }while(preference == "Y");
                            }else{
                            Console.WriteLine("Exiting Window!!!!");
                            }
                        }while( MenuChoice != 3);
                    break;
                    case 2: 
                        do{
                            ExecuteMenu();
                            MenuChoice = Int32.Parse(Console.ReadLine());
                            if(MenuChoice == 1){
                            Show readShows = new Show();
                            do{
                                readShows.Read();
                                System.Console.WriteLine("Would you like to review more shows? (Y/N)");
                                preference = Console.ReadLine().ToUpper();
                            }while(preference == "Y");
                            
                            }else if(MenuChoice == 2){
                            Show addShows = new Show();
                            do{
                                addShows.Write();
                                System.Console.WriteLine("Would you like to add more shows to the list? (Y/N)");
                                preference = Console.ReadLine().ToUpper();
                            }while(preference == "Y");
                            }else{
                            Console.WriteLine("Exiting Window!!!!");
                            }
                        }while(MenuChoice != 3);
                    break;
                    case 3: 
                        do{
                            ExecuteMenu();
                            MenuChoice = Int32.Parse(Console.ReadLine());
                            if(MenuChoice == 1){
                            Video readVideos = new Video();
                            do{
                                readVideos.Read();
                                System.Console.WriteLine("Would you like to review more videos? (Y/N)");
                                preference = Console.ReadLine().ToUpper();
                            }while(preference == "Y");
                            
                            }else if(MenuChoice == 2){
                            Video addVideo = new Video();
                            do{
                                addVideo.Write();
                                System.Console.WriteLine("Would you like to add more videos? (Y/N)");
                                preference = Console.ReadLine().ToUpper();
                            }while(preference == "Y");
                            }else{
                            Console.WriteLine("Existing Window!!!!");
                            }
                        }while( MenuChoice != 3);
                    break;
                }
            }while(MenuChoice != 4); 

        }
    }
}   