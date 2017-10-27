using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gruppprojekt
{
    [XmlRoot(Namespace = "Gruppprojekt", ElementName = "podcastlist", DataType = "string", IsNullable = true)]
    public class Podcast
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Playurl")]
        public string Playurl { get; set; }

        [XmlElement("Title")]
        public string Title { get; set; }

        [XmlElement("Category")]
        public string Category { get; set; }

        [XmlElement("Update_Interval")]
        public int Update_Interval { get; set; }

        [XmlElement("Listen_Count")]
        public int Listen_Count { get; set; }

        public Podcast(string New_Name, string New_Playurl, string New_Title, string New_Category, int New_Update_Interval, int New_Listen_Count )
        {

            Name = New_Name;
            Playurl = New_Playurl;
            Title = New_Title;
            Category = New_Category;
            Update_Interval = New_Update_Interval;
            Listen_Count = New_Listen_Count;
        }

        public Podcast()
        {

        }
    }
}
