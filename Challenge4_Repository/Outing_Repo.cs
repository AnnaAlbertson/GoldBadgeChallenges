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
    }
}
