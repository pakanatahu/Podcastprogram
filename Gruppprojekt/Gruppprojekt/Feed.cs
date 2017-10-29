using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class Feed
    {
        //TODO - Skapa en listbox/cbbox som ska hålla alla podcasternas namn, för att sedan gå vidare till avsnitten.

        private List<Podcast> PodcastList = new List<Podcast>();
        public String Category { get; set; }
        public String URL { get; set; }
        public int UpdateInterval { get; set; }
        public Feed()
        {
            PodcastList = new List<Podcast>();
        }

        public List<Podcast> GetPodcastList()
        {
            return PodcastList;
        }

        public void AddPodcast(Podcast SelectedPodcast)
        {
            PodcastList.Add(SelectedPodcast);
        }

    }
}
