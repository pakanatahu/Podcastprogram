using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gruppprojekt
{
    public class Feed : Data_Entities<Podcast>
    {
        //TODO - Skapa en listbox/cbbox som ska hålla alla podcasternas namn, för att sedan gå vidare till avsnitten.

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

    }
}
