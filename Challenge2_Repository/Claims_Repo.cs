using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Repository
{
    class Claims_Repo
    {
        Queue<Claims> _queueOfClaims = new Queue<Claims>();

        //Retrieve list of claims to use in displaying the claims
        public Queue<Claims> GetClaimsList()
        {
            return _queueOfClaims;
        }
        //Update to assist in the queue option in UI
        public void PeekNextClaim()
        {
            _queueOfClaims.Peek();   
        }
        //To remove a claim once it has been completed in the queue in UI
        public void DequeueClaim()
        {
            _queueOfClaims.Dequeue();   
        }
        //To create claim 
        public void EnquequeClaim(Claims newClaim)
        {
            _queueOfClaims.Enqueue(newClaim);
        }
    }
}
