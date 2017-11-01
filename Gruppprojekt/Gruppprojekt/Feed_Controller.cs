using System.Collections.Generic;

namespace Gruppprojekt
{
    class Feed_Controller : Data_Entities<Feed>
    {
        private List<Feed> FeedList = new List<Feed>();

        public Feed_Controller()
        {

            FeedList = new List<Feed>();
        }

        public override void AddDataToList(Feed SelectedFeed)
        {

            FeedList.Add(SelectedFeed);
        }

        public override void RemoveDataFromList(Feed SelectedFeed)
        {

            FeedList.Remove(SelectedFeed);
        }

        public override List<Feed> ReturnDataFromList()
        {

            return FeedList;
        }
    } 
}
