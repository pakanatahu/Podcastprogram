using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Gruppprojekt
{
    class XML_Handler
    {
        public void SerializeObject(List<Feed> PodcastListToBeSerialized, String PodcastListToBeSerializedURL)
        {

            //TODO när man tar bort kategori ska ett default värde komma.
            File.Delete(PodcastListToBeSerializedURL);

            XmlTextWriter XMLWriter = new XmlTextWriter(PodcastListToBeSerializedURL, null);

            foreach (Feed feed in PodcastListToBeSerialized)
            {

                XMLWriter.Formatting = Formatting.Indented;

                XMLWriter.WriteStartElement("feed");

                XMLWriter.WriteAttributeString("name", feed.Name);
                XMLWriter.WriteAttributeString("category", feed.Category);
                XMLWriter.WriteAttributeString("updateinterval", feed.UpdateInterval.ToString());
                XMLWriter.WriteAttributeString("url", feed.URL);

                foreach (Podcast podcast in feed.ReturnDataFromList())
                {

                    XMLWriter.WriteStartElement("podcast");
                    XMLWriter.WriteElementString("title", podcast.Title);
                    XMLWriter.WriteElementString("playurl", podcast.PlayURL);
                    XMLWriter.WriteElementString("summary", podcast.Summary);
                    XMLWriter.WriteElementString("publishingdate", podcast.PublishingDate);
                    XMLWriter.WriteElementString("listencount", podcast.ListenCount.ToString());
                    XMLWriter.WriteElementString("duration", podcast.Duration);
                    XMLWriter.WriteWhitespace("\n");

                    XMLWriter.WriteEndElement();
                }


            }

            XMLWriter.WriteFullEndElement();

            XMLWriter.Close();
        }

        public List<List<string>> LoadFeedDataFromXML(string FeedURL) {

            List<List<string>> FeedDataList = new List<List<string>>();

            List<string> URLList = new List<string>();
            List<string> UpdateIntervalList = new List<string>();
            List<string> CategoryList = new List<string>();
            List<string> NameList = new List<string>();

            XmlDocument XMLDocument = new XmlDocument();

            XMLDocument.Load(FeedURL);

            XmlNodeList FeedNodeList = XMLDocument.GetElementsByTagName("feed");

            for (int i = 0; i < FeedNodeList.Count; i++)
            {

                string URL = FeedNodeList[i].Attributes["url"].Value;
                string UpdateInterval = FeedNodeList[i].Attributes["updateinterval"].Value;
                string Category = FeedNodeList[i].Attributes["category"].Value;
                string Name = FeedNodeList[i].Attributes["name"].Value;

                URLList.Add(URL);
                UpdateIntervalList.Add(UpdateInterval);
                CategoryList.Add(Category);
                NameList.Add(Name);

                FeedDataList.Add(URLList);
                FeedDataList.Add(UpdateIntervalList);
                FeedDataList.Add(CategoryList);
                FeedDataList.Add(NameList);

            }

            return FeedDataList;
        }

        public void SerializeCategories(List<Category> CategoriesToBeSaved, string CategoriesURL)
        {
            File.Delete(CategoriesURL);

            XmlTextWriter XMLWriter = new XmlTextWriter(CategoriesURL, null);
            XMLWriter.Formatting = Formatting.Indented;
            XMLWriter.WriteStartElement("categories");

            foreach (Category category in CategoriesToBeSaved)
            {

                XMLWriter.WriteStartElement("category");
                XMLWriter.WriteElementString("name", category.Name);
                XMLWriter.WriteWhitespace("\n");

            }

            XMLWriter.WriteEndElement();
            XMLWriter.WriteFullEndElement();

            XMLWriter.Close();
        }

        public List<string> LoadCategoriesFromXML(string CategoriesURL)
        {

            List<string> CategoriesList = new List<string>();

            XmlDocument XMLDocument = new XmlDocument();
            XMLDocument.Load(CategoriesURL);
            XmlNodeList FeedNodeList = XMLDocument.GetElementsByTagName("category");

            for (int i = 0; i < FeedNodeList.Count; i++)
            {

                string Name = FeedNodeList[i].Attributes["name"].Value;

                CategoriesList.Add(Name);

            }

            return CategoriesList;
        }
    }
    
}
