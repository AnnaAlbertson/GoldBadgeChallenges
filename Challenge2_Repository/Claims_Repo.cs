using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Repository
{
    class Claims_Repo
    {
        List<Claims> _listOfClaims = new List<Claims>();

        //Retrieve list of claims to use in displaying the claims
        public List<Claims> GetClaimsList()
        {
            return _listOfClaims;
        }
        //Update to assist in the queue option in UI
        public void UpdateClaims()
        {

        }
        //To remove a claim once it has been completed in the queue in UI
        public void DeleteClaims()
        {

        }
        //To create claim 
        public void CreateClaim()
        {

        }
    }
}
