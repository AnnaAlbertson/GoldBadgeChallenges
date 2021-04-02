using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_Repository
{
    class Badges_Repo
    {
        private Dictionary<int, List<string>> badgesDictionary = new Dictionary<int, List<string>>();
        public void Create(Badge newBadge)
        {
            badgesDictionary.Add(newBadge.BadgeID, newBadge.DoorNames);
        }
        public void UpdateBadge()
        {

        }
        public void LookUpBadgeByID()
        {

        }
        public Dictionary<int, List<string>> GetAllBadges()
        {
            return badgesDictionary;
        }
    }
}
