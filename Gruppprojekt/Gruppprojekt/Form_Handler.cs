using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
        private BackgroundWorker UpdateIntervalWorker = new BackgroundWorker();

        private Boolean Playing;
        public string selected_category = "";

        public Form_Handler()
        {

            CreateDirectories();

        }

        public void UpdateComboBoxes(params ComboBox[] comboboxes )
        {
            foreach (ComboBox cb in comboboxes)
            {
                cb.Items.Clear();
                fillCategoryComobox(cb);
                cb.SelectedIndex = 0;
            }
        }

        public Boolean SavedPodcastListExists()
        {
            if(File.Exists(DirectoryHandler.GetSavedXMLFilesDirectory() + "PodcastSaveFile.xml"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SavedCategoryListExists()
        {
            if (File.Exists(DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveFeed(Feed feed)
        {
            FeedController.RemoveDataFromList(feed);
            //todo reload, refill.
        }

        public List<Category> getCategoryList()
        {
            return categoryHandler.getList();
        }

        public void removeCategory(String categoryName)
        {
            List<Feed> ListOfFeeds = FeedController.ReturnDataFromList();
            
            categoryHandler.removeCategory(categoryName);
            SaveCategories();
            ReloadCategories();
            foreach (Feed feed in ListOfFeeds)
            {
                if (feed.Category == categoryName)
                {
                    feed.Category = "Otilldelad";
                }
            }
        }

        public void AddCategoryName(String newName)
        {
            categoryHandler.addNewCategory(newName);
        }

        public void ChangeCategoryName(String newCategoryName, String oldCategoryName)
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

        public void set_selected_category(string selected_categ)
        {

            selected_category = selected_categ;
        }

        public void CreateNewFeed(string Name, string URL, string Category, string UpdateInterval)
        {

            int IntUpdateInterval = 0;
            IntUpdateInterval = Int32.Parse(UpdateInterval);
            Feed NewFeed = EntitiesCreator.CreateEntities(Name, URL, Category, IntUpdateInterval);
            LoadSingleBackgroundWorker(NewFeed);
            FeedController.AddDataToList(NewFeed);

        }
        public void CreateNewFeed(Feed FeedToBeUpdated)
        {
            string Name = FeedToBeUpdated.Name;
            string URL = FeedToBeUpdated.URL;
            string Category = FeedToBeUpdated.Category;
            int UpdateInterval = FeedToBeUpdated.UpdateInterval;
            string UpdateIntervalString = UpdateInterval.ToString();

            Feed NewFeed = EntitiesCreator.CreateEntities(Name, URL, Category, UpdateInterval);
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
            List<Category> CategoriesToBeSaved = getCategoryList();
            XMLHandler.SerializeObject(PodcastsToBeSaved, DirectoryHandler.GetSavedXMLFilesDirectory() + "PodcastSaveFile.xml");
            XMLHandler.SerializeCategories(CategoriesToBeSaved, DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml");
        }

        public void LoadFeedsSaving()
        {
            List<List<string>> XMLFeedData = XMLHandler.LoadFeedDataFromXML(DirectoryHandler.GetSavedXMLFilesDirectory() + "PodcastSaveFile.xml");
            //TODO trycatch om första programstarten.
            for (int i = 0; i < XMLFeedData[0].Count(); i++)
            {
                string URL = XMLFeedData[0][i];
                string UpdateInterval = XMLFeedData[1][i];
                string Category = XMLFeedData[2][i];
                string Name = XMLFeedData[3][i];
                int UpdateIntervalConverted = Int32.Parse(UpdateInterval);

                Feed NewFeed = EntitiesCreator.CreateEntities(Name, URL, Category, UpdateIntervalConverted);

                FeedController.AddDataToList(NewFeed);
            }
        }
        public void LoadCategoriesSaving()
        {

            List<string> Categories = XMLHandler.LoadCategoriesFromXML(DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml");
            
            foreach(string categoryname in Categories)
            {

                categoryHandler.addNewCategory(categoryname);
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


        public void FillFeedCombobox(ComboBox comboBox)
        {
            List<Feed> FeedToFillComboBox = FeedController.ReturnDataFromList();
            foreach (Feed feed in FeedToFillComboBox)
            {
                comboBox.Items.Add(feed);
            }
        }
        
        public void LoadAllBackgroundWorkers()
        {
            List<Feed> FeedsToBeUpdated = FeedController.ReturnDataFromList();
            foreach (Feed feed in FeedsToBeUpdated)
            {
                CreateWorkers(feed);
            }
        }

        public void LoadSingleBackgroundWorker(Feed FeedToBeUpdated)
        {
            CreateWorkers(FeedToBeUpdated);
        }
        public void CreateWorkers(Feed FeedToBeUpdated)
        {

            UpdateIntervalWorker = new BackgroundWorker();
            UpdateIntervalWorker.DoWork += new DoWorkEventHandler(UpdateIntervalWorker_DoWork);
            UpdateIntervalWorker.RunWorkerAsync(FeedToBeUpdated);
            
        }

        private void UpdateIntervalWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Feed FeedToBeUpdated = (Feed)e.Argument;
            ThreadWaitingForUpdateInterval(sender as BackgroundWorker, FeedToBeUpdated);
        }

        public void SaveCategories()
        {
            List<Category> CategoriesToBeSaved = categoryHandler.getList();
            XMLHandler.SerializeCategories(CategoriesToBeSaved, DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml");
            ReloadCategories();
        }

        private void ReloadCategories()
        {
            List<string> LoadedCategories = XMLHandler.LoadCategoriesFromXML(DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml");
            categoryHandler.ClearList();
            foreach(string category in LoadedCategories)
            {
                categoryHandler.addNewCategory(category);
            }
        }

        public void CreateStandardCategoryXMLFile()
        {
            List<string> StandardCategories = new List<string>(new string[] { "Thriller", "Sport", "Komedi", "Vetenskap", "Nyheter", "Politik", "Musik"});
            foreach (string category in StandardCategories)
            {
                categoryHandler.addNewCategory(category);
            }
            List<Category> CategoriesToBeSaved = categoryHandler.getList();
            XMLHandler.SerializeCategories(CategoriesToBeSaved, DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml");
        }

        public void ThreadWaitingForUpdateInterval(BackgroundWorker bw, Feed FeedToBeUpdated)
        {
            while (true)
            {
                int UpdateInterval = FeedToBeUpdated.UpdateInterval;
                int ConvertedUpdateInterval = 0;
                ConvertedUpdateInterval = UpdateInterval * 600000;
                System.Threading.Thread.Sleep(ConvertedUpdateInterval);
                CreateNewFeed(FeedToBeUpdated);
                FeedController.RemoveDataFromList(FeedToBeUpdated);
                XMLHandler.SerializeObject(FeedController.ReturnDataFromList(), DirectoryHandler.GetSavedXMLFilesDirectory() + "PodcastSaveFile.xml");

            }
        }




        //TODO - gör om audiplayer till internal, eftersom den bara ska användas av formhandler.
    }

}
