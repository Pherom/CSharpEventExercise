using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class DateMenuItemActionEventHandler : IMenuItemActionListener
    {
        public void PerformAction()
        {
            Console.WriteLine(string.Format("Today's date is: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")));
        }
    }
}
