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
            // Meal Number
            Console.WriteLine("Please enter the meal number of your new menu item followed by the enter key...");
            newMenuItem.MealNumber = int.Parse(Console.ReadLine());
            // Meal Name
            Console.WriteLine("Please enter the name of your new menu item followed by the enter key...");
            newMenuItem.MealName = Console.ReadLine();
            // Description
            Console.WriteLine("Please enter the description of your new menu item followed by the enter key...");
            newMenuItem.Description = Console.ReadLine();
            //Working out how to get user input and add to MealIngredients from List<SpecificEnum> didn't wuite get there in time
            // So, I changed it to a regular string
            Console.WriteLine("Please enter the ingredients in this meal: ");
            newMenuItem.MealIngredients = Console.ReadLine();
            // Price
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
            Console.WriteLine("Every menu needs to change it up every once in a while...\n" +
                "Please review the current menu before making your selection");
            ReadCurrentCafeMenu();
            //Ask user for meal number they would like to delete
            Console.WriteLine("Please enter the meal number of the menu item you would like to remove, then press enter.");
            string selection = Console.ReadLine();
            int selectedMealNumber = int.Parse(selection);
            //confirm selection

            Console.WriteLine("Are you sure you would like to remove this item (It could make a tasty comeback)? y/n");
            //if else based on choice
            string confirmRemoval = Console.ReadLine().ToLower();

            if(confirmRemoval == "y")
            {
                bool wasRemoved = _cafeRepo.DeleteMenuItem(selectedMealNumber);
                if (wasRemoved)
                {
                    Console.WriteLine("Making room for better dishes on the menu.....................................\n" +
                        "The menu item you selected is now deleted.");
                }
                else
                {
                    Console.WriteLine("I'm sorry the menu item you selected could not be deleted.\n" +
                        "The meal item could have already been deleted or does not exist.");
                }
            }
            else
            {
                Console.WriteLine("I'm happy to hear this dish will be sticking around a little longer");
            }
            
        }

        //SeedContentList to prevent starting with an empty list of CafeMenu
        private void SeedCafeMenuList()
        {
            CafeMenu menuItemOne = new CafeMenu(1, "Spinach Feta Omelette Cups",
                "An order of delectable baked eggs in the form of muffin bottoms\n" +
                "with all the great flavors of a perfectly cooked omelette filled\n" +
                "with our signature blend of spices, spinach, and feta.", 9.79m, "eggs, spinach, feta");

            _cafeRepo.AddMenuItem(menuItemOne);

            CafeMenu menuItemTwo = new CafeMenu(2, "Crab Cake Benedict",
                "Our famous crab cakes on an english muffin topped with a\n" +
                "beautifully poached egg and some house-made hollandaise\n" +
                "sauce served with sauteed spinach and bacon.", 13.89m, "english muffin, crab cakes, " +
                "eggs, hollandaise, spinach, bacon");

            _cafeRepo.AddMenuItem(menuItemTwo);

            CafeMenu menuItemThree = new CafeMenu(3, "Blueberry Muffins",
                "These perfectly crumbly, decadent muffins with a burst of\n" +
                "blueberry flavor will have you saying 'mmm...mmm... good'\n" +
                "Scratch-made, freshly baked every morning.", 8.99m, "blueberries and muffin mix");

            _cafeRepo.AddMenuItem(menuItemThree);
        }
    }
}
