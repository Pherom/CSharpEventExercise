using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class Delegates
    {

        public static void Run()
        {
            MainMenu mainMenu = new MainMenu();
            MenuItem menuItem1 = new MenuItem("Show Date/Time", mainMenu);
            MenuItem menuItem1a = new MenuItem("Show Time", menuItem1);
            MenuItem menuItem1b = new MenuItem("Show Date", menuItem1);
            menuItem1a.Chosen += displayCurrentTime;
            menuItem1b.Chosen += displayCurrentDate;
            menuItem1.AddMenuItem(menuItem1a);
            menuItem1.AddMenuItem(menuItem1b);
            MenuItem menuItem2 = new MenuItem("Version And Spaces", mainMenu);
            MenuItem menuItem2a = new MenuItem("Count Spaces", menuItem2);
            MenuItem menuItem2b = new MenuItem("Show Version", menuItem2);
            menuItem2a.Chosen += displayCountSpacesForm;
            menuItem2b.Chosen += displayVersion;
            menuItem2.AddMenuItem(menuItem2a);
            menuItem2.AddMenuItem(menuItem2b);
            mainMenu.AddMenuItem(menuItem1);
            mainMenu.AddMenuItem(menuItem2);
            mainMenu.Show();
        }

        private static void displayCurrentTime()
        {
            Console.WriteLine(string.Format("The time is: {0}", DateTime.Now.ToString("HH:mm")));
        }

        private static void displayCurrentDate()
        {
            Console.WriteLine(string.Format("Today's date is: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")));
        }

        private static void displayCountSpacesForm()
        {
            string input;
            Console.WriteLine("Please enter a sentence from which to count spaces:");
            input = Console.ReadLine();
            Console.WriteLine(String.Format("Found {0} spaces", input.Count(char.IsWhiteSpace)));
        }

        private static void displayVersion()
        {
            Console.WriteLine("Version: 22.2.4.8950");
        }
    }
}
