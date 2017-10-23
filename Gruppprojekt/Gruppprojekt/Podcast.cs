using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class Podcast
    {
        public string Playurl { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Update_Intervall { get; set; }
        public int Listen_Count { get; set; }
        
        public Podcast(string New_Playurl, string New_Title, string New_Category, int New_Update_Intervall, int New_Listen_Count )
        {
            Playurl = New_Playurl;
            Title = New_Title;
            Category = New_Category;
            Update_Intervall = New_Update_Intervall;
            Listen_Count = New_Listen_Count;
        }
    }
}
