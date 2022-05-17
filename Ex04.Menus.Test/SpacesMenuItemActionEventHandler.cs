using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class SpacesMenuItemActionEventHandler : IMenuItemActionListener
    {
        public void PerformAction()
        {
            string input;
            Console.WriteLine("Please enter a sentence from which to count spaces:");
            input = Console.ReadLine();
            Console.WriteLine(String.Format("Found {0} spaces", input.Count(char.IsWhiteSpace)));
        }
    }
}