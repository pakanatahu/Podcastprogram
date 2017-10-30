using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gruppprojekt
{
    class Entities_Creator
    {

        public Feed CreateEntities(String FeedName, String FeedURL, String FeedCategory, int FeedUpdateInterval)

        {
            Boolean FeedCreated = false;

            Feed NewFeed = new Feed();

            var XMLDocument = new System.Xml.XmlDocument();
            XNamespace NameSpace = "http://www.itunes.com/dtds/podcast-1.0.dtd";
            XMLDocument = RSSFeedDownloader(FeedURL);

            foreach (System.Xml.XmlNode Item in XMLDocument.DocumentElement.SelectNodes("channel/item"))
            {
                if (!FeedCreated)
                {
                    NewFeed = CreateFeed(FeedName, FeedCategory, FeedURL, FeedUpdateInterval);
                    FeedCreated = true;

                }

                string Title = Item.SelectSingleNode("title").InnerText;
                string PlayURL = Item.SelectSingleNode("link").InnerText;
                //string Summary = Item.SelectSingleNode("//[local-name() = 'summary']").InnerText;
                //string Duration = Item.SelectSingleNode("//[local-name() = 'duration']").InnerText;
                string PublishingDate = Item.SelectSingleNode("pubDate").InnerText;
                int ListenCount = 0;

                NewFeed.AddDataToList(CreatePodcast(Title, PlayURL, "Summary", "Duration", PublishingDate, ListenCount));

            }
            return NewFeed;
        }

        private Feed CreateFeed(string Name, string Category, string URL, int UpdateInterval)
        {
            Feed NewFeed = new Feed();

            NewFeed.Name = Name;
            NewFeed.Category = Category;
            NewFeed.URL = URL;
            NewFeed.UpdateInterval = UpdateInterval;

            return NewFeed;
        }
        private Podcast CreatePodcast(string Title, string PlayURL, string Summary, string Duration, string PublishingDate, int ListenCount)
        {

            Podcast NewPodcast = new Podcast();

            NewPodcast.Title = Title;
            NewPodcast.PlayURL = PlayURL;
            NewPodcast.Summary = Summary;
            NewPodcast.Duration = Duration;
            NewPodcast.PublishingDate = PublishingDate;
            NewPodcast.ListenCount = ListenCount;

            return NewPodcast;
        }

        internal System.Xml.XmlDocument RSSFeedDownloader(string FeedURL)
        {
            var XMLString = "";

            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                XMLString = client.DownloadString(FeedURL);

            }

            var NewXMLDocument = new System.Xml.XmlDocument();
            NewXMLDocument.LoadXml(XMLString);

            return NewXMLDocument;
        }
    }
}
