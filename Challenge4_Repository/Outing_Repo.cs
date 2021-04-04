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
        public decimal CostByCategory(EventType eventType)
        {
            foreach(Outing outing in _listOfOutings)
            {
                if (outing.TypeOfEvent == eventType)
                {
                    List<decimal> listOfEventCosts = new List<decimal>();
                    listOfEventCosts.Add(outing.TotalCostEvent);
                    decimal costOfEventOutings = listOfEventCosts.Select(x => x).Sum();
                    return costOfEventOutings;
                }
            }
            return 0;
        }
    }
}