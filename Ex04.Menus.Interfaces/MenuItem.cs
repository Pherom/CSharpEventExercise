using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : Menu
    {
        private readonly List<IMenuItemActionListener> r_Listeners = new List<IMenuItemActionListener>();

        public MenuItem(string i_Title, Menu i_PreviousMenu) : base(i_Title, "Back", i_PreviousMenu)
        {

        }

        public void AddMenuItemActionListener(IMenuItemActionListener i_Listener)
        {
            r_Listeners.Add(i_Listener);
        }

        public void RemoveMenuItemActionListener(IMenuItemActionListener i_Listener)
        {
            r_Listeners.Remove(i_Listener);
        }

        private void notifyAllMenuItemActionListeners()
        {
            foreach (IMenuItemActionListener listener in r_Listeners)
            {
                listener.PerformAction();
            }
        }

        public void OnMenuItemAction()
        {
            if (r_MenuItems.Count > 0)
            {
                Console.Clear();
                Show();
            }
            notifyAllMenuItemActionListeners();
            if (r_MenuItems.Count == 0)
            {
                if (r_PreviousMenu != null)
                {
                    r_PreviousMenu.Show();
                }
            }
        }
    }
}
