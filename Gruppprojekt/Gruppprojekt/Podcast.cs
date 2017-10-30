using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gruppprojekt
{
    public class Podcast
    {

        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "PlayURL")]
        public string PlayURL { get; set; }

        [XmlElement(ElementName = "Summary")]
        public string Summary { get; set; }

        [XmlElement(ElementName = "Duration")]
        public string Duration { get; set; }

        [XmlElement(ElementName = "PublishingDate")]
        public string PublishingDate { get; set; }

        [XmlElement(ElementName = "ListenCount")]
        public int ListenCount { get; set; }

        public Podcast()
        {

        }

    }
}
