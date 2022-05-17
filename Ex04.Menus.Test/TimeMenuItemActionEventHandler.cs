using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class TimeMenuItemActionEventHandler : IMenuItemActionListener
    {
        public void PerformAction()
        {
            Console.WriteLine(string.Format("The time is: {0}", DateTime.Now.ToString("HH:mm")));
        }
    }
}
