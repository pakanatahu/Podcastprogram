using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gruppprojekt
{
    class podcast_saver
    {
        XmlSerializer serial = new XmlSerializer(typeof(Podcast));
        Podcast_Handler p_h = new Podcast_Handler();

        public podcast_saver()
        {
          
        }

        public void serialize_podcast()
        {

            using (var stream = new StreamWriter("podcast.xml"))
            {
                serial.Serialize(stream, p_h.GetPodcastList());
            }
        }
    }
}
