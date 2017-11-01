using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Gruppprojekt
{
    public class Feed : Data_Entities<Podcast>
    {

        private List<Podcast> PodcastList = new List<Podcast>();

        [XmlElement(ElementName = "Name")]
        public String Name { get; set; }
        [XmlElement(ElementName = "Category")]
        public String Category { get; set; }
        [XmlElement(ElementName = "URL")]
        public String URL { get; set; }
        [XmlElement(ElementName = "UpdateInterval")]
        public int UpdateInterval { get; set; }

        public Feed()
        {

            PodcastList = new List<Podcast>();
        }

        public override void AddDataToList(Podcast SelectedPodcast)
        {

            PodcastList.Add(SelectedPodcast);
        }

        public override void RemoveDataFromList(Podcast SelectedPodcast)
        {

            PodcastList.Remove(SelectedPodcast);
        }

        public override List<Podcast> ReturnDataFromList()
        {

            return PodcastList;
        }

        public void IncrementListenCount(string PodcastTitle)
        {
            Podcast SelectedPodcast = PodcastList.Find(item => item.Title == PodcastTitle);
            SelectedPodcast.ListenCount++;
        }

    }
}
