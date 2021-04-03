using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge3_Repository;

namespace Challenge3_Console
{
    class ProgramUI
    { 
        private Badges_Repo repo = new Badges_Repo();
        // Run method containing methods in UI
        public void Run()
        {
            //SeedBadges();
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
                        AddBadge();
                        break;
                    case "2":
                        // Edit a badge
                        EditBadge();
                        break;
                    case "3":
                        // List all badges
                        ListBadges();
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
            //new instance of badge
            Badge newBadge = new Badge();

            // Adding key value for badge ID
            Console.Write("What is the number on the badge: ");
            string badgeIDString = Console.ReadLine();
            int badgeIDInt = int.Parse(badgeIDString);
            newBadge.BadgeID = badgeIDInt;

            AddDoor();
            
            //Console.Write("List a door it needs access to: ");
            //string doorResponse = Console.ReadLine();
            //// newbadge.DoorNames = 
            //Console.Write("Any other doors (y/n)? ");
            //string otherDoorResponse = Console.ReadLine().ToLower(); 
            //if (otherDoorResponse == "y")
            //{
            //    Console.Write("List a door it needs access to: ");
            //}
            //else if (otherDoorResponse == "n")
            //{
            //    repo.Create(newBadge);
            //    Menu();
            //}
            //else
            //{
            //    Console.WriteLine("Please enter 'y' for yes or 'n' for no");
            //}
            repo.Create(newBadge);
        }
        private void EditBadge()
        {

        }
        private void RemoveDoor()
        {

        }
        private List<string> AddDoor()
        {
            List<string> doorAccess = new List<string>();

            bool needsDoor = true;
            while(needsDoor)
            {
                Console.Write("List a door that it needs access to: ");
                string doorAccessResponse = Console.ReadLine();
                doorAccess.Add(doorAccessResponse);

                Console.Write("Any other doors (y/n)? ");
                string otherDoorResponse = Console.ReadLine().ToLower();
                if (otherDoorResponse == "y")
                {
                    break;
                }
                else if (otherDoorResponse == "n")
                {
                    return doorAccess;
                    needsDoor = false;
                }
                else
                {
                    Console.WriteLine("Please enter 'y' for yes or 'n' for no");
                }
            }
            return null;
        }
        private void ListBadges()
        {

        }
        private void SeedBadges()
        {

        }
    }
}
