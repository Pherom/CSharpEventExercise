using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem : Menu
    {
        public MenuItem(string i_Title, Menu i_PreviousMenu) : base(i_Title, "Back", i_PreviousMenu)
        {

        }
    }
}
