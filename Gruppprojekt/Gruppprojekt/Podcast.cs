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
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Playurl")]
        public string Playurl { get; set; }

        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "Category")]
        public string Category { get; set; }

        [XmlElement(ElementName = "Update_Interval")]
        public int Update_Interval { get; set; }

        [XmlElement(ElementName = "Listen_Count")]
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
