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
            Console.Clear();
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

                Console.WriteLine("\nPlease press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void SeeClaims()
        {
            Console.Clear();
            Queue<Claims> claimsQueue = repo.GetClaimsQueue();
            // To display in a table I found a video to help : https://www.youtube.com/watch?v=Bni04KLDOcg&list=PL1iWr76IK-QXzw1Ei3CzIilzYID6Gl83d&index=2&t=104s
            foreach (Claims claim in claimsQueue)
            {
                Console.WriteLine("\nClaimID:{0} " +
                    "\nType:{1} " +
                    "\nDescription:{2} " +
                    "\nAmount:${3} " +
                    "\nDateOfAccident:{4} " +
                    "\nDateOfClaim:{5} " +
                    "\nIsValid:{6}", 
                    claim.ClaimID, 
                    claim.TypeOfClaim, 
                    claim.Description, 
                    claim.ClaimAmount, 
                    claim.DateOfIncident.ToString("d"), 
                    claim.DateOfClaim.ToString("d"), 
                    claim.IsValid);
            }
        }
        private void NextClaim()
        {
            Console.Clear();
            // Collecting need variables and methods
            Queue<Claims> claimsQueue = repo.GetClaimsQueue();
            Claims claim = claimsQueue.Peek();
            // Display to user
            Console.WriteLine($"\nClaimID:{claim.ClaimID} " +
                $"\nType:{claim.TypeOfClaim} " +
                $"\nDescription:{claim.Description} " +
                $"\nAmount:${claim.ClaimAmount} " +
                $"\nDateOfAccident:{claim.DateOfIncident} " +
                $"\nDateOfClaim:{claim.DateOfClaim} " +
                $"\nIsValid:{claim.IsValid}");

            TakeCareOfClaim();
            Console.Clear();
        }
        private void TakeCareOfClaim()
        {
            Console.Write("\nDo you want to deal with this claim now? (y/n)");
            string response = Console.ReadLine();
            if (response == "y")
            {
                repo.DequeueClaim();
                Console.WriteLine("Thank you for taking care of the claim. \nThis claim has now been removed.");
                Console.ReadKey();
            }
            else if (response == "n")
            {
                Console.WriteLine("The claim will remain at the top of the queue. \nPlease take care of the claim when you are ready.");
                Console.ReadKey();
                Menu();
            }
            else
            {
                Console.WriteLine("Please enter 'y' for yes or 'n' for no...");
            }
        }
        private void NewClaim()
        {
            Console.Clear();
            Claims newClaim = new Claims();

            // Gather Properties
            // Claim ID
            Console.Write("\nEnter the claim id: ");
            string claimIDInput = Console.ReadLine();
            newClaim.ClaimID = Convert.ToInt32(claimIDInput);
            
            // Collecting enum
            // Need a way to collect string and convert to enum (switch case maybe??)
            Console.WriteLine("\nPlease enter the number matching the type of claim: \n" +
                "\n1) Car" +
                "\n2) Home" +
                "\n3) Theft");
            string typeOfClaimAsString = Console.ReadLine();
            int typeOfClaimAsInt = int.Parse(typeOfClaimAsString);
            newClaim.TypeOfClaim = (ClaimType)typeOfClaimAsInt;
            
            //Description
            Console.Write("\nEnter a claim description: ");
            newClaim.Description = Console.ReadLine();
            Console.Write("\nAmount of Damage: $");
            string claimAmountString = Console.ReadLine();
            newClaim.ClaimAmount = decimal.Parse(claimAmountString);
            
            //Dates
            Console.Write("\nDate of Accident: ");
            string accidentDateString = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(accidentDateString);
            Console.Write("\nDate of Claim: ");
            string claimDateString = Console.ReadLine();
            newClaim.DateOfClaim = Convert.ToDateTime(claimDateString);

            // Is Valid print (if else statement/ "This claim is valid." or "This claim is not valid."     
            Console.Write("Is Valid: " + newClaim.IsValid);

            repo.EnquequeClaim(newClaim);
        }
        private void SeedClaimQueue()
        {
            // Seeding Queue
            Claims claim1 = new Claims(1, ClaimType.Car, "Car accident on 465.", 400.00m, new DateTime(2018, 04, 25), new DateTime(2018, 04, 11));
            Claims claim2 = new Claims(2, ClaimType.Home, "House fire in kitchen.", 4000.00m, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));
            Claims claim3 = new Claims(3, ClaimType.Theft, "Stolen pancakes.", 4.00m, new DateTime(2018, 04, 27), new DateTime(2018, 06, 1));

            // Adding to Queue
            repo.EnquequeClaim(claim1);
            repo.EnquequeClaim(claim2);
            repo.EnquequeClaim(claim3);
        }   
    }
}
