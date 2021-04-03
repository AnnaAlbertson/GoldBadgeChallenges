using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge4_Repository;

namespace Challenge4_Console
{
    class ProgramUI
    {
        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            //While Loop to keep program running
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to user
                Console.WriteLine("Welcome to Komodo Accounting Resource!\n" +
                    "How would you like to continue?\n" +
                    "\n" +                    
                    "1) Display a list of all outings.\n" +
                    "2) Add an outing.\n" +
                    "3) View calculations.\n" +
                    "4) Exit.\n" +
                    "\n" +
                    "Please enter your selection below then press enter to continue...");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        // Display list of all outings
                        DisplayOutings();
                        break;
                    case "2":
                        // Add an outing
                        AddOuting();            
                        break;
                    case "3":
                        // View calculations
                        Calculations();
                        break;
                    case "4":
                        // Exit
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
        private void DisplayOutings()
        {
            Console.Clear();
            List<Outing> listOfOutings = 
        }
        private void AddOuting()
        {

        }
        private void Calculations()
        {
            Console.WriteLine("Would you like to view...\n" +
                "1) the combined cost of all outings\n" +
                "or" +
                "2) the cost of outings by type");
        }
        private void CombinedCostOutings()
        {

        }
        private void CombinedCostByCategory()
        {

        }
    }
}
