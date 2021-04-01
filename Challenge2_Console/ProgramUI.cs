using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge2_Repository;

namespace Challenge2_Console
{
    class ProgramUI
    {
        private Claims_Repo repo = new Claims_Repo();
        public void Run()
        {
            SeedClaimQueue();
            Menu();
        }

        private void Menu()
        {
            //While Loop to keep program running
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to user
                Console.WriteLine("Welcome to Komodo Insurance claims management software!\n" +
                    "Choose a menu item:\n" +
                    "\n" +
                    "1) See all claims.\n" +
                    "2) Take care of next claim.\n" +
                    "3) Enter a new claim.\n" +
                    "4) Exit\n" +
                    "\n" +
                    "Please enter your selection below then press enter to continue...");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        // See all claims
                        SeeClaims();
                        break;
                    case "2":
                        // View next claim
                        NextClaim();
                        break;
                    case "3":
                        // Create new claim
                        NewClaim();
                        break;
                    case "4":
                        // leaving
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a menu item listed above.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void SeeClaims()
        {
            repo.GetClaimsQueue();
        }
        private void NextClaim()
        {

        }
        private void NewClaim()
        {

        }
        private void SeedClaimQueue()
        {
            Claims claim1 = new Claims(1, ClaimType.Car, "Car accident on 465.", 400.00m, new DateTime(2018, 04, 25), new DateTime(2018, 04, 11));
            Claims claim2 = new Claims(2, ClaimType.Home, "House fire in kitchen.", 4000.00m, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));
            Claims claim3 = new Claims(3, ClaimType.Theft, "Stolen pancakes.", 4.00m, new DateTime(2018, 04, 27), new DateTime(2018, 06, 1));
        }   
    }
}
