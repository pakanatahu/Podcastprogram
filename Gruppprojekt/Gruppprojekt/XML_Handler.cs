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

            //TODO när man tar bort kategori ska ett default värde komma.
            File.Delete(PodcastListToBeSerializedURL);

            XmlTextWriter XMLWriter = new XmlTextWriter(PodcastListToBeSerializedURL, null);

            foreach(Feed feed in PodcastListToBeSerialized) {

                XMLWriter.Formatting = Formatting.Indented;

                XMLWriter.WriteStartElement("feeds");

                XMLWriter.WriteAttributeString("feedname", feed.Name);
                XMLWriter.WriteAttributeString("category", feed.Category);
                XMLWriter.WriteAttributeString("url", feed.URL);
                XMLWriter.WriteAttributeString("updateinterval", feed.UpdateInterval.ToString());

                foreach (Podcast podcast in feed.ReturnDataFromList()) {

                    XMLWriter.WriteStartElement("podcast");
                    XMLWriter.WriteElementString("title", podcast.Title);
                    XMLWriter.WriteElementString("playurl", podcast.PlayURL);
                    XMLWriter.WriteElementString("summary", podcast.Summary);
                    XMLWriter.WriteElementString("publishingdate", podcast.PublishingDate);
                    XMLWriter.WriteElementString("listencount", podcast.ListenCount.ToString());
                    XMLWriter.WriteElementString("duration", podcast.Duration);
                    XMLWriter.WriteWhitespace("\n");
                    XMLWriter.WriteEndElement();
                }    
            }

            XMLWriter.WriteFullEndElement();
            XMLWriter.Close();
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
