using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class Menu
    {
        private const string k_Separator = "------------------------";
        private readonly string r_Title;
        protected readonly Menu r_PreviousMenu;
        protected readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        private readonly string r_ZeroOptionText;

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public Menu(string i_Title, string i_ZeroOptionText = "Exit", Menu i_PreviousMenu = null)
        {
            r_Title = i_Title;
            r_ZeroOptionText = i_ZeroOptionText;
            r_PreviousMenu = i_PreviousMenu;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }

        public void RemoveMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Remove(i_MenuItem);
        }

        private void performZeroOperation()
        {
            if (r_PreviousMenu != null)
            {
                Console.Clear();
                r_PreviousMenu.Show();
            }
        }

        private void displayTitle()
        {
            Console.WriteLine(String.Format("**{0}**", r_Title));
        }

        private void displayMenuItems()
        {
            Console.WriteLine(k_Separator);
            for (int i = 1; i <= r_MenuItems.Count; i++)
            {
                Console.WriteLine(String.Format("{0} -> {1}", i, r_MenuItems[i - 1].Title));
            }
            Console.WriteLine(string.Format("0 -> {0}{1}{2}", r_ZeroOptionText, Environment.NewLine, k_Separator));
        }

        private void displayUserInstructions()
        {
            Console.WriteLine(string.Format("Enter your request: ({0} - {1} or 0 to {2})", 0, r_MenuItems.Count, r_ZeroOptionText));
        }

        private bool checkInputValidity(string i_Input)
        {
            int inputAsInteger;
            bool valid = int.TryParse(i_Input, out inputAsInteger);
            if (valid && (inputAsInteger < 0 || inputAsInteger > r_MenuItems.Count))
            {
                valid = false;
            }

            return valid;
        }

        private bool tryReadingUserInput(out int o_Result)
        {
            bool valid;
            string input = Console.ReadLine();
            valid = checkInputValidity(input);
            if (valid == true)
            {
                o_Result = int.Parse(input);
            }
            else
            {
                o_Result = 0;
            }

            return valid;
        }

        public void Show()
        {
            bool validInput = true;
            int result;
            do
            {
                displayTitle();
                displayMenuItems();
                if (validInput == false)
                {
                    Console.WriteLine(String.Format("Input must be an integer between {0} and {1}!", 0, r_MenuItems.Count));
                }
                displayUserInstructions();
                validInput = tryReadingUserInput(out result);
            } while (validInput == false);
            if (result == 0)
            {
                performZeroOperation();
            }
            else
            {
                r_MenuItems[result - 1].OnMenuItemAction();
            }
        }
    }
}
