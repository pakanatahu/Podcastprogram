using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Gruppprojekt
{
    class Main_Logic_Delegater
    {

        internal WMPLib.WindowsMediaPlayer WindowsPlayer;

        private Category_Handler CategoryHandler;
        private Feed PodcastFeed;
        private Feed_Controller FeedController;
        private Entities_Creator EntitiesCreator;
        private Directory_Handler DirectoryHandler;
        private MP3_Downloader MP3Downloader;
        private XML_Handler XMLHandler;
        private BackgroundWorker UpdateIntervalWorker;

        private Boolean Playing;
        public string selected_category = "";

        public Main_Logic_Delegater()
        {
            CategoryHandler = new Category_Handler();
            PodcastFeed = new Feed();
            FeedController = new Feed_Controller();
            EntitiesCreator = new Entities_Creator();
            DirectoryHandler = new Directory_Handler();
            MP3Downloader = new MP3_Downloader();
            XMLHandler = new XML_Handler();
            UpdateIntervalWorker = new BackgroundWorker();
            WindowsPlayer = new WindowsMediaPlayer();
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

        public Boolean SavedPodcastExists(Podcast SelectedPodcast)
        {
            if (File.Exists(DirectoryHandler.GetPlayableMP3File(SelectedPodcast)))
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
            HandleXMLSaving();
        }

        public void ManageFeed(Feed FeedToBeChanged, string FeedChoice, string FeedChange)
        {
            Feed FeedToBeChangedTemporary = FeedToBeChanged;
            FeedController.RemoveDataFromList(FeedToBeChanged);
            switch(FeedChoice)
            {
                case "Name":
                    FeedToBeChangedTemporary.Name = FeedChange;
                    break;

                case "URL":
                    FeedToBeChangedTemporary.URL = FeedChange;
                    break;

                case "UpdateInterval":
                    FeedToBeChangedTemporary.UpdateInterval = Int32.Parse(FeedChange);
                    break;

                case "Category":
                    FeedToBeChangedTemporary.Category = FeedChange;
                    break;

                default:
                    break;
            }
            FeedController.AddDataToList(FeedToBeChangedTemporary);
            HandleXMLSaving();
        }


        public List<Category> getCategoryList()
        {
            return CategoryHandler.getList();
        }

        public void removeCategory(String categoryName)
        {
            List<Feed> ListOfFeeds = FeedController.ReturnDataFromList();
            
            CategoryHandler.removeCategory(categoryName);
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
            CategoryHandler.addNewCategory(newName);
        }

        public void ChangeCategoryName(String newCategoryName, String oldCategoryName)
        {
            CategoryHandler.changeName(newCategoryName, oldCategoryName);
        }

        public void fillCategoryComobox(ComboBox cb)
        {
            foreach(Category category in CategoryHandler.getList())
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

        public void SetSelectedCategory(string selected_categ)
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

            List<String> PodcastInfoList = new List<String>(new String[] { SelectedPodcast.Title, SelectedPodcast.PublishingDate, SelectedPodcast.ListenCount.ToString() });

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

        public void StartAlreadyDownloadedMP3(Podcast SelectedPodcast, Feed SelectedFeed)
        {

            Podcast SelectedPodcastTemporary = SelectedPodcast;
            Feed SelectedFeedTemporary = SelectedFeed;

            SelectedFeedTemporary.RemoveDataFromList(SelectedPodcast);

            FeedController.RemoveDataFromList(SelectedFeedTemporary);

            SelectedPodcastTemporary.ListenCount++;

            SelectedFeedTemporary.AddDataToList(SelectedPodcastTemporary);

            FeedController.AddDataToList(SelectedFeedTemporary);

            HandleXMLSaving();
            StartAudio(DirectoryHandler.GetPlayableMP3File(SelectedPodcast));
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
            for (int i = 0; i < XMLFeedData[0].Count(); i++)
            {
                string URL = XMLFeedData[0][i];
                string UpdateInterval = XMLFeedData[1][i];
                string Category = XMLFeedData[2][i];
                string Name = XMLFeedData[3][i];
                int UpdateIntervalConverted = Int32.Parse(UpdateInterval);

                Feed NewFeed = EntitiesCreator.CreateEntitiesFromSaveFile(DirectoryHandler.GetSavedXMLFilesDirectory() + "PodcastSaveFile.xml", Name, URL, Category, UpdateIntervalConverted);

                FeedController.AddDataToList(NewFeed);
            }
        }
        public void LoadCategoriesSaving()
        {

            List<string> Categories = XMLHandler.LoadCategoriesFromXML(DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml");
            
            foreach(string categoryname in Categories)
            {

                CategoryHandler.addNewCategory(categoryname);
            }

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
            List<Category> CategoriesToBeSaved = CategoryHandler.getList();
            XMLHandler.SerializeCategories(CategoriesToBeSaved, DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml");
            ReloadCategories();
        }

        private void ReloadCategories()
        {
            List<string> LoadedCategories = XMLHandler.LoadCategoriesFromXML(DirectoryHandler.GetSavedXMLFilesDirectory() + "CategoriesSaveFile.xml");
            CategoryHandler.ClearList();
            foreach(string category in LoadedCategories)
            {
                CategoryHandler.addNewCategory(category);
            }
        }

        public void CreateStandardCategoryXMLFile()
        {
            List<string> StandardCategories = new List<string>(new string[] { "Thriller", "Sport", "Komedi", "Vetenskap", "Nyheter", "Politik", "Musik"});
            foreach (string category in StandardCategories)
            {
                CategoryHandler.addNewCategory(category);
            }
            List<Category> CategoriesToBeSaved = CategoryHandler.getList();
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

    }

}
