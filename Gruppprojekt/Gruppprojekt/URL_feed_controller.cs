using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class URL_feed_controller
    {
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
                var title = item.SelectSingleNode("title");
                Output += title.InnerText;
                playurl, titel, kategori, intervall
            }

            return Output;
        }
    }
}
