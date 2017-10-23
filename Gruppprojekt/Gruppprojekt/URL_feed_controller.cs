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

        public string Get_RSS()
        {
            string Output = "";
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("http://www.aftonbladet.se/rss.xml");
            }

            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/item"))
            {
                string playurl = item.SelectSingleNode("link").InnerText;
                string title = item.SelectSingleNode("title").InnerText;
                string category = item.SelectSingleNode("category").InnerText;
                int update_intervall = 1;
                int listen_count = 0;
                Podcast P_C = new Podcast(playurl, title, category, update_intervall, listen_count);
                Podcast_list.Add(P_C);

            }

            foreach (Podcast pc in Podcast_list)
            {
                Output += pc.Title;
            }

            return Output;
        }
    }
}
