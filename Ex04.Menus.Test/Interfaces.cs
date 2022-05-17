using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class Interfaces
    {
        public static void Run()
        {
            MainMenu mainMenu = new MainMenu();
            MenuItem menuItem1 = new MenuItem("Show Date/Time", mainMenu);
            MenuItem menuItem1a = new MenuItem("Show Time", menuItem1);
            MenuItem menuItem1b = new MenuItem("Show Date", menuItem1);
            menuItem1a.AddMenuItemActionListener(new TimeMenuItemActionEventHandler());
            menuItem1b.AddMenuItemActionListener(new DateMenuItemActionEventHandler());
            menuItem1.AddMenuItem(menuItem1a);
            menuItem1.AddMenuItem(menuItem1b);
            MenuItem menuItem2 = new MenuItem("Version And Spaces", mainMenu);
            MenuItem menuItem2a = new MenuItem("Count Spaces", menuItem2);
            MenuItem menuItem2b = new MenuItem("Show Version", menuItem2);
            menuItem2a.AddMenuItemActionListener(new SpacesMenuItemActionEventHandler());
            menuItem2b.AddMenuItemActionListener(new VersionMenuItemActionEventHandler());
            menuItem2.AddMenuItem(menuItem2a);
            menuItem2.AddMenuItem(menuItem2b);
            mainMenu.AddMenuItem(menuItem1);
            mainMenu.AddMenuItem(menuItem2);
            mainMenu.Show();
        }
    }
}
