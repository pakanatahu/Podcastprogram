using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class Podcast_Handler
    {
        private List<Podcast> PodcastList = new List<Podcast>();

        public Podcast_Handler()
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
