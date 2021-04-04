using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4_Repository
{
    public class Outing_Repo
    {
        private List<Outing> _listOfOutings = new List<Outing>();
        public List<Outing> GetListOfOutings()
        {
            return _listOfOutings;   
        }
        public void AddOuting(Outing newOuting)
        {
            _listOfOutings.Add(newOuting);
        }
        public decimal AddCostEvents()
        {
            // Google helped me
            decimal costOfOutings = _listOfOutings.Select(x => x.TotalCostEvent).Sum();
            return costOfOutings;
        }
        public decimal CostByCategory()
        {
            foreach(Outing outing in _listOfOutings)
            {
                if (outing.TypeOfEvent == EventType.Golf)
                {
                    List<decimal> listOfGolfCosts = new List<decimal>();
                    listOfGolfCosts.Add(outing.TotalCostEvent);
                    decimal costOfGolfOutings = listOfGolfCosts.Select(x => x).Sum();
                    return costOfGolfOutings;
                }
                else if (outing.TypeOfEvent == EventType.Bowling)
                {
                    List<decimal> listOfBowlingCosts = new List<decimal>();
                    listOfBowlingCosts.Add(outing.TotalCostEvent);
                    decimal costOfBowlingOutings = listOfBowlingCosts.Select(x => x).Sum();
                    return costOfBowlingOutings;
                }
                else if (outing.TypeOfEvent == EventType.AmusementPark)
                {
                    List<decimal> listOfAmusementParkCosts = new List<decimal>();
                    listOfAmusementParkCosts.Add(outing.TotalCostEvent);
                    decimal costOfAmusementParkOutings = listOfAmusementParkCosts.Select(x => x).Sum();
                    return costOfAmusementParkOutings;
                }
                else if (outing.TypeOfEvent == EventType.Concert)
                {
                    List<decimal> listOfConcertCosts = new List<decimal>();
                    listOfConcertCosts.Add(outing.TotalCostEvent);
                    decimal costOfConcertOutings = listOfConcertCosts.Select(x => x).Sum();
                    return costOfConcertOutings;
                }
            }
            return 0;
        }
    }
}
                //foreach (StreamingContent content in _listOfContent)
                //{
                //    if (content.Title.ToLower() == title.ToLower())
                //    {
                //        return content;
                //    }
                //}

                //return null;
