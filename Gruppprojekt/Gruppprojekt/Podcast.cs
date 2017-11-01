using System.Xml.Serialization;

namespace Gruppprojekt
{
    public class Podcast
    {

        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "PlayURL")]
        public string PlayURL { get; set; }

        [XmlElement(ElementName = "PublishingDate")]
        public string PublishingDate { get; set; }

        [XmlElement(ElementName = "ListenCount")]
        public int ListenCount { get; set; }

        public Podcast()
        {

        }

    }
}
