using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_Console
{
    class ProgramUI
    { // Run method containing methods in UI
        private void Run()
        {
            SeedBadges();
            Menu();
        }
        private void Menu()
        {
            Console.Clear();
            //While Loop to keep program running
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to user
                Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                    "\n" +
                    "1) Add a badge.\n" +
                    "2) Edit a badge.\n" +
                    "3) List all badges.\n" +
                    "4) Exit\n" +
                    "\n" +
                    "Please enter your selection below then press enter to continue...");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        // Add a badge
                        
                        break;
                    case "2":
                        // Edit a badge
                        
                        break;
                    case "3":
                        // List all badges
                        
                        break;
                    case "4":
                        // leaving
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a menu item listed above.");
                        break;
                }
                Console.WriteLine("\nPlease press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void AddBadge()
        {

        }
        private void EditBadge()
        {

        }
        private void RemoveDoor()
        {

        }
        private void AddDoor()
        {

        }
        private void ListBadges()
        {

        }
        private void SeedBadges()
        {

        }
    }
}
