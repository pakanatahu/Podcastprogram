using System;
using System.Text;
using System.Xml;

namespace Gruppprojekt
{
    class Entities_Creator
    {
        public Feed CreateEntitiesFromSaveFile(string URL, string FeedName, string FeedURL, string FeedCategory, int FeedUpdateInterval)
        {
            Boolean FeedCreated = false;

            Feed NewFeed = new Feed();

            var XMLDocument = new System.Xml.XmlDocument();
            XMLDocument.Load(URL);

            XmlNodeList FeedDataNodeList = XMLDocument.SelectNodes("/feeds/feed/podcast");

            foreach (XmlNode Item in FeedDataNodeList)
            {
                if (!FeedCreated)
                {
                    NewFeed = CreateFeed(FeedName, FeedCategory, FeedURL, FeedUpdateInterval);
                    FeedCreated = true;

                }

                string Title = Item.SelectSingleNode("title").InnerText;
                string PlayURL = Item.SelectSingleNode("playurl").InnerText;
                string PublishingDate = Item.SelectSingleNode("publishingdate").InnerText;
                string StringListenCount = Item.SelectSingleNode("listencount").InnerText;

                int ListenCount = Int32.Parse(StringListenCount);

                Podcast NewPodcast = CreatePodcast(Title, PlayURL, PublishingDate, ListenCount);
                NewFeed.AddDataToList(NewPodcast);

            }
            return NewFeed;
        }
        public Feed CreateEntities(string FeedName, string FeedURL, string FeedCategory, int FeedUpdateInterval)
        {

            Boolean FeedCreated = false;

            Feed NewFeed = new Feed();

            var XMLDocument = new System.Xml.XmlDocument();
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
                string PublishingDate = Item.SelectSingleNode("pubDate").InnerText;
                int ListenCount = 0;

                Podcast NewPodcast = CreatePodcast(Title, PlayURL, PublishingDate, ListenCount);
                NewFeed.AddDataToList(NewPodcast);

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
        private Podcast CreatePodcast(string Title, string PlayURL, string PublishingDate, int ListenCount)
        {

            Podcast NewPodcast = new Podcast();

            NewPodcast.Title = Title;
            NewPodcast.PlayURL = PlayURL;
            NewPodcast.PublishingDate = PublishingDate;
            NewPodcast.ListenCount = ListenCount;

            return NewPodcast;
        }
        public Category CreateCategory(string Name)
        {

            Category NewCategory = new Category(Name);

            return NewCategory;
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
