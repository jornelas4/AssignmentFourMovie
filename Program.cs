using System;


namespace AssignmentFourMovie
{
    class Program
    {

         
         
        static void Main(string[] args)
        {

            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

            // This section is only built to show the movie
           Menu menu = new Menu();
            menu.MenuChoice();
        }
    }
}
