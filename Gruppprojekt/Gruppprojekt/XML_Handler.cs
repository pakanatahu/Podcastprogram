using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Gruppprojekt
{
    class XML_Handler
    {
        public void SerializeObject(List<Feed> PodcastListToBeSerialized, String PodcastListToBeSerializedURL)
        {

            var Serializer = new XmlSerializer(typeof(List<Feed>));
            using (var Stream = File.OpenWrite(PodcastListToBeSerializedURL))
            {
                Serializer.Serialize(Stream, PodcastListToBeSerialized);
            }
        }

        public void Deserialize(List<Feed> PodcastListToBeDeserialized, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Feed>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<Feed>)(serializer.Deserialize(stream));
                PodcastListToBeDeserialized.Clear();
                PodcastListToBeDeserialized.AddRange(other);
            }
            
        }


        }
    
}
