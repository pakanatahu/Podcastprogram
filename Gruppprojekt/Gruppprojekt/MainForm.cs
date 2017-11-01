using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppprojekt
{
    public partial class MainForm : Form
    {
        private Main_Logic_Delegater MainLogicDelegater;
        private Validator validator;
        
        public MainForm()
        {
            InitializeComponent();
            MainLogicDelegater = new Main_Logic_Delegater();
            validator = new Validator();
            ListBoxPodcasts.DisplayMember = "Title";
            ListBoxFeeds.DisplayMember = "Name";
            ComboBoxManageFeed.DisplayMember = "Name";
            CheckForXMLLoadFile();
            ReloadListBoxes();
            MainLogicDelegater.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories, ComboBoxManageFeedChange);
            MainLogicDelegater.LoadAllBackgroundWorkers();
        }
        private void CheckForXMLLoadFile()
        {

            if (MainLogicDelegater.SavedCategoryListExists())
            {

                MainLogicDelegater.LoadCategoriesSaving();
            }
            else
            {

                MainLogicDelegater.CreateStandardCategoryXMLFile();
            }
            if (MainLogicDelegater.SavedPodcastListExists())
            {

                MainLogicDelegater.LoadFeedsSaving();
            }
        }
        private void ReloadListBoxes()
        {
            ListBoxFeeds.Items.Clear();
            ListBoxPodcasts.Items.Clear();
            ComboBoxManageFeed.Items.Clear();
            MainLogicDelegater.FillListBoxFeeds(ListBoxFeeds);
            MainLogicDelegater.FillFeedCombobox(ComboBoxManageFeed);

        }

        private void ButtonAddRSS_Click(object sender, EventArgs e)
        {
            string UpdateInterval = TextBoxAddRSSIntervall.Text;

            try
            {
                validator.validateInterval(UpdateInterval);

                string Name = TextBoxAddRSSName.Text;
                string URL = TextBoxAddRSSURL.Text;
                string Category = ComboBoxAddRSS.SelectedItem.ToString();

                MainLogicDelegater.CreateNewFeed(Name, URL, Category, UpdateInterval);
                ListBoxFeeds.Items.Clear();
                MainLogicDelegater.HandleXMLSaving();
                MainLogicDelegater.FillListBoxFeeds(ListBoxFeeds);

                TextBoxAddRSSName.Clear();
                TextBoxAddRSSURL.Clear();
                TextBoxAddRSSIntervall.Text = "HH";

                MessageBox.Show("Podcastfeed added!");
                ReloadListBoxes();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void ButtonPlay_Click(object sender, EventArgs e)
        {
            Podcast SelectedPodcast = ListBoxPodcasts.SelectedItem as Podcast;
            Feed SelectedFeed = ListBoxFeeds.SelectedItem as Feed;
            try
            {
                if(MainLogicDelegater.SavedPodcastExists(SelectedPodcast)) {
                    MainLogicDelegater.StartAlreadyDownloadedMP3(SelectedPodcast, SelectedFeed);
                    ButtonQuitMusicPlayback.Visible = true;
                    ButtonPlayPause.Visible = true;
                    ButtonPlay.Visible = false;
                    lbNowPlaying.Text = "Spelar upp...";

                }
                else {

                    Task<String> DownloadMP3Task = MainLogicDelegater.DownloadAudioHandler(SelectedPodcast);
                    lbNowPlaying.Text = "Laddar ner...";

                    await DownloadMP3Task;

                    lbNowPlaying.Text = DownloadMP3Task.Result;

                    ButtonQuitMusicPlayback.Visible = true;
                    ButtonPlayPause.Visible = true;
                    ButtonPlay.Visible = false;
                    lbNowPlaying.Text = "Spelar upp...";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + " Task did not load.");
            }
        }

            private void ButtonShowMore_Click(object sender, EventArgs e)
        {
            Podcast SelectedPodcast = ListBoxPodcasts.SelectedItem as Podcast;
            if (SelectedPodcast != null)
            {
                List<String> PodcastInfoTempList = MainLogicDelegater.GetPodcastInfo(ListBoxPodcasts.SelectedItem as Podcast);
                ShowMorePodcastInfo PodcastInfoWindow = new ShowMorePodcastInfo(PodcastInfoTempList);
                PodcastInfoWindow.Show();
            }
        }

        public void UpdateComboboxes()
        {
            MainLogicDelegater.UpdateComboBoxes(ComboBoxCategory, ComboBoxCategory);
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxFeeds.Items.Clear();
            ListBoxPodcasts.Items.Clear();

            MainLogicDelegater.SetSelectedCategory(ComboBoxCategory.SelectedItem.ToString());
            MainLogicDelegater.FillListBoxFeeds(ListBoxFeeds);
        }

        private void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            MainLogicDelegater.StartPauseAudio();
        }

        private void ButtonManageFeeds_Click(object sender, EventArgs e)
        {
            try
            {

                Feed FeedToChange = ComboBoxManageFeed.SelectedItem as Feed;
                Category CategoryForFeed = ComboBoxManageFeedChange.SelectedItem as Category;

                string NewCategory = CategoryForFeed.Name;

                bool hasValueName = validator.hasValue(TextBoxManageFeedName.Text);
                bool hasValueURL = validator.hasValue(TextBoxManageFeedURL.Text);
                bool hasValueInterval = validator.hasValue(TextBoxManageFeedUpdateInterval.Text);

                if (hasValueName)
                {
                    validator.validateName(TextBoxManageFeedName.Text);
                    MainLogicDelegater.ManageFeed(FeedToChange, "Name", TextBoxManageFeedName.Text);
                }
                if (hasValueURL)
                {
                    validator.validateUrl(TextBoxManageFeedURL.Text);
                    MainLogicDelegater.ManageFeed(FeedToChange, "URL", TextBoxManageFeedURL.Text);
                }
                if (hasValueInterval)
                {
                    validator.validateInterval(TextBoxManageFeedUpdateInterval.Text);
                    MainLogicDelegater.ManageFeed(FeedToChange, "UpdateInterval", TextBoxManageFeedUpdateInterval.Text);
                }
                MainLogicDelegater.ManageFeed(FeedToChange, "Category", NewCategory);
                ReloadListBoxes();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        
        private void ButtonQuitMusicPlayback_Click(object sender, EventArgs e)
        {
            MainLogicDelegater.QuitMusicPlayer();
            ButtonQuitMusicPlayback.Visible = false;
            ButtonPlayPause.Visible = false;
            ButtonPlay.Visible = true;
            lbNowPlaying.Text = "";
        }

        private void ListBoxFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {

            Feed SelectedFeed = ListBoxFeeds.SelectedItem as Feed;
            if(SelectedFeed != null) {
                ListBoxPodcasts.Items.Clear();
                MainLogicDelegater.FillListBoxPodcasts(ListBoxPodcasts, SelectedFeed);
            }
        }

        private void ButtonManageCategoriesRemove_Click(object sender, EventArgs e)
        {
            var ChoosenCategory = ComboBoxManageCategories.SelectedItem.ToString();
            MainLogicDelegater.removeCategory(ChoosenCategory);
            MessageBox.Show(ChoosenCategory + " har tagits bort som kategori");
            MainLogicDelegater.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
        }

        private void ButtonManageCategoriesSave_Click(object sender, EventArgs e)
        {
            var NewName = TextBoxManageCategoriesNewName.Text;
            var OldName = ComboBoxCategory.SelectedItem.ToString();

            try 
            {
                validator.validateCategory(NewName, MainLogicDelegater.getCategoryList());
                MainLogicDelegater.ChangeCategoryName(NewName, OldName);
                MainLogicDelegater.SaveCategories();
                MainLogicDelegater.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
                MessageBox.Show(OldName + " har döpts om till " + NewName);
                ReloadListBoxes();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonManageCategoriesCreate_Click(object sender, EventArgs e)
        {
            var NewCategory = TextBoxAddCategory.Text;
            MainLogicDelegater.AddCategoryName(NewCategory);
            MainLogicDelegater.SaveCategories();
            MainLogicDelegater.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
            MessageBox.Show(NewCategory + " har lagts till som ny kategori");
            TextBoxAddCategory.Clear();
            ReloadListBoxes();
        }

    }
}
