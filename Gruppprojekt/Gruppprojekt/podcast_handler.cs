using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class podcast_handler
    {
        private List<Podcast> podcast_list = new List<Podcast>();

        public podcast_handler()
        {
            podcast_list = new List<Podcast>();
        }

        public List<Podcast> get_podcast_list()
        {
            return podcast_list;
        }

        public void add_podcast(Podcast podcast)
        {
            podcast_list.Add(podcast);
        }
    }
}
