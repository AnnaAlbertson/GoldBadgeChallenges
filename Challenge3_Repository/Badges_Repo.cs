using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_Repository
{
    public class Badges_Repo
    {
        private Dictionary<int, List<string>> badgesDictionary = new Dictionary<int, List<string>>();
        public void Create(Badge newBadge)
        {
            badgesDictionary.Add(newBadge.BadgeID, newBadge.DoorNames);
        }
        public void UpdateBadge(int badgeID)
        {

        }
        //Helper method
        public bool FindKeyValuePair(int badgeID)
        {
            foreach(KeyValuePair<int, List<string>> badgePair in badgesDictionary)
            {
                if (badgePair.Key == badgeID)
                {

                    return true;
                }
            }
            return false;
        }
        public Dictionary<int, List<string>> GetAllBadges()
        {
            return badgesDictionary;
        }
    }
}

//// Helper method
//public StreamingContent GetContentByTitle(string title)
//{
//    foreach (StreamingContent content in _listOfContent)
//    {
//        if (content.Title.ToLower() == title.ToLower())
//        {
//            return content;
//        }
//    }

//    return null;
//}
//// Update
//public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
//{
//    // Find the content
//    StreamingContent oldContent = GetContentByTitle(originalTitle);

//    // Update the conent
//    if (oldContent != null)
//    {
//        oldContent.Title = newContent.Title;
//        oldContent.Description = newContent.Description;
//        oldContent.MaturityRating = newContent.MaturityRating;
//        oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
//        oldContent.StarRating = newContent.StarRating;
//        oldContent.TypeOfGenre = newContent.TypeOfGenre;

//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//// Delete
//public bool RemoveContentFromList(string title)
//{
//    StreamingContent content = GetContentByTitle(title);

//    if (content == null)
//    {
//        return false;
//    }

//    int initialCount = _listOfContent.Count;
//    _listOfContent.Remove(content);

//    if (initialCount > _listOfContent.Count)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

