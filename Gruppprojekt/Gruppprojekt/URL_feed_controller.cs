using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class URL_feed_controller
    {
        List<Podcast> Podcast_list = new List<Podcast>();

        public void Create_Podcast(String name, String url, string category, int update_intervall)
        {
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/item"))
            {
                string playurl = item.SelectSingleNode("link").InnerText;
                string title = item.SelectSingleNode("title").InnerText;

                Podcast p_c = new Podcast(name, playurl, title, category, update_intervall, 0);
                Podcast_list.Add(p_c);

            }
        }
    }
}
