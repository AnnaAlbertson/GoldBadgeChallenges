using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Cafe_Repository
{
    public class CafeMenu_Repository
    {
        //Field to access the List of CafeMenu items
        private List<CafeMenu> _listOfCafeMenu = new List<CafeMenu>();

        //Return list of Cafe Menu
        public List<CafeMenu> ReturnList()
        {
            return _listOfCafeMenu;
        }

        //Create new menu items
        public void AddMenuItem(CafeMenu menuItem)
        {
            _listOfCafeMenu.Add(menuItem);
        }

        //Read menu items
        public List<CafeMenu> ReadMenuItems()
        {
            return _listOfCafeMenu;
        }

        //Delete menu items
        public bool DeleteMenuItem(int mealNumber)
        {
            CafeMenu menuItem = GetMenuItemByMealNumber(mealNumber);

            if(menuItem == null)
            {
                return false;
            }

            int initialCount = _listOfCafeMenu.Count;
            _listOfCafeMenu.Remove(menuItem);

            if (initialCount > _listOfCafeMenu.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        public CafeMenu GetMenuItemByMealNumber(int mealNumber)
        {
            foreach (CafeMenu menuItem in _listOfCafeMenu)
            {
                if(menuItem.MealNumber == mealNumber)
                {
                    return menuItem;
                }

            }
            return null;
        }
    }
}
