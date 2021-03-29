using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1_Cafe_Repository;

namespace Challenge1_Cafe_Console
{
    class ProgramUI
    {
        private CafeMenu_Repository _cafeRepo = new CafeMenu_Repository();

        //Run Method to start and run program
        public void Run()
        {
            SeedCafeMenuList();
            Menu();
        }

        //Menu method
        private void Menu()
        {

        }

        //Create a cafe menu item
        private void CreateNewMenuItem()
        {

        }

        //Read current cafe menu
        private void ReadCurrentCafeMenu()
        {

        }
        
        //Delete a cafe menu item
        private void RemoveAMenuItem()
        {

        }

        //SeedContentList to prevent starting with an empty list of CafeMenu
        private void SeedCafeMenuList()
        {
            CafeMenu menuItemOne = new CafeMenu(1, "Spinach Feta Omelette Cups",
                "An order of delectable baked eggs in the form of muffin bottoms " +
                "with all the great flavors of a perfectly cooked omelette filled " +
                "with our signature blend of spices, spinach, and feta.", 9.79m);
            menuItemOne.MealIngredients.Add(CafeIngredients.Eggs);
            menuItemOne.MealIngredients.Add(CafeIngredients.Spinach);
            menuItemOne.MealIngredients.Add(CafeIngredients.Feta);

            CafeMenu menuItemTwo = new CafeMenu(2, "Crab Cake Benedict",
                "Our famous crab cakes on an english muffin topped with a" +
                "beautifully poached egg and some house-made hollandaise" +
                "sauce served with sauteed spinach and bacon.", 13.89m);
            menuItemTwo.MealIngredients.Add(CafeIngredients.EnglishMuffin);
            menuItemTwo.MealIngredients.Add(CafeIngredients.CrabCakes);
            menuItemTwo.MealIngredients.Add(CafeIngredients.Eggs);
            menuItemTwo.MealIngredients.Add(CafeIngredients.Hollandaise);
            menuItemTwo.MealIngredients.Add(CafeIngredients.Spinach);
            menuItemTwo.MealIngredients.Add(CafeIngredients.Bacon);

            CafeMenu menuItemThree = new CafeMenu(3, "Blueberry Muffins",
                "These perfectly crumbly, decadent muffins with a burst of" +
                "blueberry flavor will have you saying 'mmm...mmm... good'" +
                "Scratch-made, freshly baked every morning.", 8.99m)

            _cafeRepo.AddMenuItem(menuItemOne);
            _cafeRepo.AddMenuItem(menuItemTwo);
            _cafeRepo.AddMenuItem(menuItemThree);
        }
    }
}
