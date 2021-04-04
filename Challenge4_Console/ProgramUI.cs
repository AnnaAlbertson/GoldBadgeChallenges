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
        private Outing_Repo repo = new Outing_Repo();
        public void Run()
        {
            SeedOutings();
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
            List<Outing> listOfOutings = repo.GetListOfOutings();
            foreach(Outing outing in listOfOutings)
            {
                Console.WriteLine($"Event Type: {outing.TypeOfEvent}\n" +
                    $"Number of people attended: {outing.PeopleInAttendance}\n" +
                    $"Date of event: {outing.EventDate.ToString("d")}\n" +
                    $"Total cost per person: ${outing.TotalCostPerPerson}\n" +
                    $"Total cost for the event: ${outing.TotalCostEvent}\n");
            }
        }
        private void AddOuting()
        {
            Console.Clear();
            // Create new instance of Outing
            Outing newOuting = new Outing();

            // Gather properties
            // Type of Event
            Console.Write("What type of event is the outing: \n" +
                "1) Golf\n" +
                "2) Bowling\n" +
                "3) Amusement Park\n" +
                "4) Concert\n");
            string typeOfEventString = Console.ReadLine();
            switch (typeOfEventString)
            {
                case "1":
                    // Golf
                    newOuting.TypeOfEvent = EventType.Golf;
                    break;
                case "2":
                    // Bowling
                    newOuting.TypeOfEvent = EventType.Bowling;
                    break;
                case "3":
                    // Amusement Park
                    newOuting.TypeOfEvent = EventType.AmusementPark;
                    break;
                case "4":
                    // Concert
                    newOuting.TypeOfEvent = EventType.Concert;
                    break;
                default:
                    // For error catching
                    Console.WriteLine("Please enter an option listed above");
                    break;
            }
            // Number of people attended
            Console.Write("Number of people in attendance: ");
            string attendanceString = Console.ReadLine();
            int attendanceInt = int.Parse(attendanceString);
            newOuting.PeopleInAttendance = attendanceInt;
            // Date
            Console.Write("Date of event: ");
            string dateString = Console.ReadLine();
            DateTime dateDateTime = DateTime.Parse(dateString);
            newOuting.EventDate = dateDateTime;
            // Total cost per person
            Console.Write("Total cost per person: ");
            string costPerPersonString = Console.ReadLine();
            decimal costPerPersonDecimal = decimal.Parse(costPerPersonString);
            newOuting.TotalCostPerPerson = costPerPersonDecimal;

            //Display total cost of event
            Console.WriteLine("The total cost of the event you entered is: $" + newOuting.TotalCostEvent);

            repo.AddOuting(newOuting);
        }
        private void Calculations()
        {
            Console.Clear();
            Console.WriteLine("Would you like to view...\n" +
                "1) the combined cost of all outings\n" +
                "or\n" +
                "2) the cost of outings by type");
            string calculationChoice = Console.ReadLine();
            if(calculationChoice == "1")
            {
                CombinedCostOutings();
            }
            else if(calculationChoice == "2")
            {
                CombinedCostByCategory();
            }
            else
            {
                Console.WriteLine("Please enter either 1 or 2.");
                Calculations();
            }
        }
        private void CombinedCostOutings()
        {
            decimal totalCostOfEvents = repo.AddCostEvents();
            Console.WriteLine("The total cost of outings this year is: $" + totalCostOfEvents);
        }
        private void CombinedCostByCategory()
        {
            // cost of golf outings
            decimal costOfGolfOutings = repo.CostByCategory(EventType.Golf);
            Console.WriteLine("The cost of all golf outings this year were: $" + costOfGolfOutings);
            // cost of bowling outings
            decimal costOfBowlingOutings = repo.CostByCategory(EventType.Bowling);
            Console.WriteLine("The cost of all golf outings this year were: $" + costOfBowlingOutings);
            // cost of amusement park outings
            decimal costOfAmusementParkOutings = repo.CostByCategory(EventType.AmusementPark);
            Console.WriteLine("The cost of all golf outings this year were: $" + costOfAmusementParkOutings);
            // cost of concert outings
            decimal costOfConcertOutings = repo.CostByCategory(EventType.Concert);
            Console.WriteLine("The cost of all golf outings this year were: $" + costOfConcertOutings);
        }
        private void SeedOutings()
        {
            Outing bowlingTournament = new Outing(EventType.Bowling, 45, new DateTime(2020, 05, 15), 89.70m);
            Outing dayAtCedarPoint = new Outing(EventType.AmusementPark, 180, new DateTime(2020, 06, 02), 220.50m);
            Outing valentinesConcert = new Outing(EventType.Concert, 36, new DateTime(2020, 02, 14), 145.65m);

            repo.AddOuting(bowlingTournament);
            repo.AddOuting(dayAtCedarPoint);
            repo.AddOuting(valentinesConcert);
        }
    }
}
