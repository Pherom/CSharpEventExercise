using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class VersionMenuItemActionEventHandler : IMenuItemActionListener
    {
        public void PerformAction()
        {
            Console.WriteLine("Version: 22.2.4.8950");
        }
    }
}
