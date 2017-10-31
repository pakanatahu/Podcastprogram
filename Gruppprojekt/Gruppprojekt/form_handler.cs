using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Gruppprojekt
{
    class Form_Handler
    {

        internal WMPLib.WindowsMediaPlayer WindowsPlayer = new WindowsMediaPlayer();

        private CategoryHandler categoryHandler = new CategoryHandler();
        private Feed PodcastFeed = new Feed();
        private Feed_Controller FeedController = new Feed_Controller();
        private Entities_Creator EntitiesCreator = new Entities_Creator();
        private Directory_Handler DirectoryHandler = new Directory_Handler();
        private MP3_Downloader MP3Downloader = new MP3_Downloader();
        private XML_Handler XMLHandler = new XML_Handler();

        private Boolean Playing;
        public string selected_category = "";

        public Form_Handler()
        {

            CreateDirectories();

        }

        public void updateComboBoxes(params ComboBox[] comboboxes )
        {
            foreach (ComboBox cb in comboboxes)
            {
                cb.Items.Clear();
                fillCategoryComobox(cb);
            }
        }

        public List<Category> getCategoryList()
        {
            return categoryHandler.getList();
        }

        public void removeCategory(String categoryName)
        {
            categoryHandler.removeCategory(categoryName);
        }

        public void addCategoryName(String newName)
        {
            categoryHandler.addNewCategory(newName);
        }

        public void changeCateogoryName(String newCategoryName, String oldCategoryName)
        {
            categoryHandler.changeName(newCategoryName, oldCategoryName);
        }

        public void fillCategoryComobox(ComboBox cb)
        {
            foreach(Category category in categoryHandler.getList())
            {
                cb.Items.Add(category.Name);
            }
        }

        public void FillListBoxFeeds(ListBox listbox)
        {
            //TODO Sortera på titelnummret, göra om filllist till en istället för två.
            List<Feed> FeedToFillBox = FeedController.ReturnDataFromList();

            foreach (Feed feed in FeedToFillBox)
            {
                if (feed.Category == selected_category)
                {
                    listbox.Items.Add(feed);
                }

            }
        }

        public void FillListBoxPodcasts(ListBox listbox, Feed SelectedFeed)
        {

            List<Podcast> PodcastToFillBox = SelectedFeed.ReturnDataFromList();

            foreach (Podcast podcast in PodcastToFillBox)
            {
                listbox.Items.Add(podcast);

            }
        }

        public void setSelectedCategoryInCombobox(ComboBox cb, int index)
        {
            cb.SelectedIndex = index;
        }

        public void set_selected_category(string selected_categ)
        {

            selected_category = selected_categ;
        }

        public void SendInput(string Name, string URL, string Category, string UpdateInterval)
        {

            //TODO fixa uppdaterings frekvens.
            int IntUpdateInterval = 0;
            int IntUpdateInterval = ConvertStringToUpdateinterval(UpdateInterval);
            Feed NewFeed = EntitiesCreator.CreateEntities(Name, URL, Category, IntUpdateInterval);

            FeedController.AddDataToList(NewFeed);

        }

        public List<String> GetPodcastInfo(Podcast SelectedPodcast)
        {

            List<String> PodcastInfoList = new List<String>(new String[] { SelectedPodcast.Title,
                SelectedPodcast.PublishingDate, SelectedPodcast.Duration, SelectedPodcast.Summary, SelectedPodcast.ListenCount.ToString() });

            return PodcastInfoList;
        }

        public async Task<string> DownloadAudioHandler(Podcast SelectedPodcast)
        {

            String Title = SelectedPodcast.Title;
            String PlayURL = SelectedPodcast.PlayURL;

            Task<String> DownloadMP3Task = MP3Downloader.DownloadMP3FileAsync(Title, PlayURL);

            await DownloadMP3Task;

            StartAudio(DirectoryHandler.GetPlayableMP3File(SelectedPodcast));
            SelectedPodcast.ListenCount++;

            return DownloadMP3Task.Result;
        }

        public void CreateDirectories()
        {
            DirectoryHandler.CreateProgramRootDirectory();
            DirectoryHandler.CreateMP3DownloadDirectory();
            DirectoryHandler.CreateXMLSaveDirectory();
        }

        public void HandleXMLSaving()
        {

            List<Feed> PodcastsToBeSaved = FeedController.ReturnDataFromList();
            XMLHandler.SerializeObject(PodcastsToBeSaved, DirectoryHandler.GetSavedXMLFile() + "PodcastSaveFile.xml");
        }

        public void LoadXMLSaving()
        {

            List<List<string>> XMLFeedData = XMLHandler.LoadFeedDataFromXMLAsDictionary(DirectoryHandler.GetSavedXMLFile() + "PodcastSaveFile.xml");

            for (int i = 0; i < XMLFeedData.Count(); i++)
            {
                string Name = XMLFeedData[i][i];
                string URL = XMLFeedData[i+1][i];
                string Category = XMLFeedData[i+2][i];
                string UpdateInterval = XMLFeedData[i + 3][i];

                Feed NewFeed = EntitiesCreator.CreateEntities(Name, URL, Category, UpdateInterval);

                FeedController.AddDataToList(NewFeed);
            }
        }

        public void StartPauseAudio()
        {

            CheckIfPlayingOrPaused();
        }

        public void QuitMusicPlayer()
        {

            WindowsPlayer.controls.stop();
        }

        private void StartAudio(String MP3URL)
        {

            WindowsPlayer.URL = MP3URL;
            WindowsPlayer.controls.play();
            Playing = true;
        }

        private void CheckIfPlayingOrPaused()
        {

            if (Playing)
            {
                WindowsPlayer.controls.pause();
            }
            else
            {
                WindowsPlayer.controls.play();
            }

            Playing = !Playing;
        }

        internal int ConvertStringToUpdateinterval(string StringNumber)
        {
            int ConvertedNumber = 0;

            string[] SplittedString = StringNumber.Split(':');

            int Hours = Int32.Parse(SplittedString[0]);
            int Minutes = Int32.Parse(SplittedString[1]);

            Hours = Hours * 60;

            ConvertedNumber = Hours + Minutes;

            return ConvertedNumber;
        }


        //TODO - gör om audiplayer till internal, eftersom den bara ska användas av formhandler.
    }

}
