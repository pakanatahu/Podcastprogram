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

        public void CreateXMLDocument(String DirectoryToBeSaved, String FileName, List<Podcast> PodcastsToBeSaved)
        {
            XmlRootAttribute XMLRoot = new XmlRootAttribute();
            XMLRoot.ElementName = "podcastlist";
            XMLRoot.Namespace = "Gruppprojekt";
            XMLRoot.IsNullable = true;
            XmlSerializer Serializer = new XmlSerializer(PodcastsToBeSaved.GetType(), XMLRoot);
            StreamWriter Writer = new StreamWriter(@DirectoryToBeSaved + FileName + ".xml");
            Serializer.Serialize(Writer.BaseStream, PodcastsToBeSaved);

        }

        public void LoadXMLDocument(String DirectoryToBeSaved, String FileName, List<Podcast> PodcastsToBeDeserialized)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Podcast>));
            StreamReader srdr = new StreamReader(@DirectoryToBeSaved + FileName + ".xml");
            PodcastsToBeDeserialized = (List<Podcast>)xmlser.Deserialize(srdr);
            srdr.Close();

        }

        }
    
}
