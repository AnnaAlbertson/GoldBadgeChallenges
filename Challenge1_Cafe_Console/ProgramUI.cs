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
            //While Loop to keep program running
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to user
                Console.WriteLine("Welcome to Komodo Cafe's Menu Editor!\n" +
                    "What would you like to do today?\n" +
                    "\n" +
                    "I would like to...\n" +
                    "1)add a new item to our menu...\n" +
                    "2)read our current menu...\n" +
                    "3)remove an item from our menu...\n" +
                    "4)leave now, please.\n" +
                    "\n" +
                    "Please enter your selection below then press enter to continue...");

                string selection = Console.ReadLine();
               
                switch (selection)
                {
                    case "1":
                        // Create new menu item
                        CreateNewMenuItem();
                        break;
                    case "2":
                        // View current menu
                        ReadCurrentCafeMenu();
                        break;
                    case "3":
                        // View content by title
                        RemoveAMenuItem();
                        break;
                    case "4":
                        // leaving
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number listed above.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create a cafe menu item
        private void CreateNewMenuItem()
        {
            Console.Clear();
            CafeMenu newMenuItem = new CafeMenu();

            //Prompt user for the properties
            Console.WriteLine("Please enter the meal number of your new menu item followed by the enter key...");
            newMenuItem.MealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the name of your new menu item followed by the enter key...");
            newMenuItem.MealName = Console.ReadLine();
            Console.WriteLine("Please enter the description of your new menu item followed by the enter key...");
            newMenuItem.Description = Console.ReadLine();

            //Working out how to get user input and add to MealIngredients
            //newMenuItem.MealIngredients = Console.ReadLine();
            Console.WriteLine("Please enter the price of your new menu item followed by the enter key...");
            newMenuItem.Price = decimal.Parse(Console.ReadLine());

            _cafeRepo.AddMenuItem(newMenuItem);
        }

        //Read current cafe menu
        private void ReadCurrentCafeMenu()
        {
            Console.Clear();
            List<CafeMenu> currentCafeMenu = _cafeRepo.ReadMenuItems();

            foreach (CafeMenu menuItem in currentCafeMenu)
            {
                Console.WriteLine($"Meal Number: {menuItem.MealNumber}\n" +
                    $"Meal Name: {menuItem.MealName}\n" +
                    $"Description: {menuItem.Description}\n" +
                    $"Ingredients: {menuItem.MealIngredients}\n" +
                    $"Price: ${menuItem.Price}\n" +
                    $"");
            }
        }
        
        //Delete a cafe menu item
        private void RemoveAMenuItem()
        {
            Console.Clear();
        }

        //SeedContentList to prevent starting with an empty list of CafeMenu
        private void SeedCafeMenuList()
        {
            CafeMenu menuItemOne = new CafeMenu(1, "Spinach Feta Omelette Cups",
                "An order of delectable baked eggs in the form of muffin bottoms\n" +
                "with all the great flavors of a perfectly cooked omelette filled\n" +
                "with our signature blend of spices, spinach, and feta.", 9.79m);

            _cafeRepo.AddMenuItem(menuItemOne);

            //menuItemOne.MealIngredients.Add(CafeIngredients.Eggs);
            //menuItemOne.MealIngredients.Add(CafeIngredients.Spinach);
            //menuItemOne.MealIngredients.Add(CafeIngredients.Feta);

            CafeMenu menuItemTwo = new CafeMenu(2, "Crab Cake Benedict",
                "Our famous crab cakes on an english muffin topped with a\n" +
                "beautifully poached egg and some house-made hollandaise\n" +
                "sauce served with sauteed spinach and bacon.", 13.89m);

            _cafeRepo.AddMenuItem(menuItemTwo);

            //menuItemTwo.MealIngredients.Add(CafeIngredients.EnglishMuffin);
            //menuItemTwo.MealIngredients.Add(CafeIngredients.CrabCakes);
            //menuItemTwo.MealIngredients.Add(CafeIngredients.Eggs);
            //menuItemTwo.MealIngredients.Add(CafeIngredients.Hollandaise);
            //menuItemTwo.MealIngredients.Add(CafeIngredients.Spinach);
            //menuItemTwo.MealIngredients.Add(CafeIngredients.Bacon);

            CafeMenu menuItemThree = new CafeMenu(3, "Blueberry Muffins",
                "These perfectly crumbly, decadent muffins with a burst of\n" +
                "blueberry flavor will have you saying 'mmm...mmm... good'\n" +
                "Scratch-made, freshly baked every morning.", 8.99m);

            _cafeRepo.AddMenuItem(menuItemThree);

            //menuItemThree.MealIngredients.Add(CafeIngredients.Blueberries);
            //menuItemThree.MealIngredients.Add(CafeIngredients.MuffinMix);                
        }
    }
}
