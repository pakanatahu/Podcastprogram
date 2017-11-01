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
        Main_Logic MainLogic = new Main_Logic();
        Validator validator = new Validator();
        
        public MainForm()
        {
            InitializeComponent();

            ListBoxPodcasts.DisplayMember = "Title";
            ListBoxFeeds.DisplayMember = "Name";
            ComboBoxManageFeed.DisplayMember = "Name";
            CheckForXMLLoadFile();
            ReloadListBoxes();
            MainLogic.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories, ComboBoxManageFeedChange);
            MainLogic.LoadAllBackgroundWorkers();
        }
        private void CheckForXMLLoadFile()
        {

            if (MainLogic.SavedCategoryListExists())
            {
                MainLogic.LoadCategoriesSaving();
            }
            else
            {
                MainLogic.CreateStandardCategoryXMLFile();
            }

            if (MainLogic.SavedPodcastListExists())
            {
                MainLogic.LoadFeedsSaving();

            }
        }
        private void ReloadListBoxes()
        {
            ListBoxFeeds.Items.Clear();
            ListBoxPodcasts.Items.Clear();
            ComboBoxManageFeed.Items.Clear();
            MainLogic.FillListBoxFeeds(ListBoxFeeds);
            MainLogic.FillFeedCombobox(ComboBoxManageFeed);

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
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

                MainLogic.CreateNewFeed(Name, URL, Category, UpdateInterval);
                ListBoxFeeds.Items.Clear();
                MainLogic.HandleXMLSaving();
                MainLogic.FillListBoxFeeds(ListBoxFeeds);

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

            Task<String> DownloadMP3Task = MainLogic.DownloadAudioHandler(SelectedPodcast);
            lbNowPlaying.Text = "Laddar ner...";

            await DownloadMP3Task;

            lbNowPlaying.Text = DownloadMP3Task.Result;

            ButtonQuitMusicPlayback.Visible = true;
            ButtonPlayPause.Visible = true;
            ButtonPlay.Visible = false;
            lbNowPlaying.Text = "Spelar upp...";
        }

        private void ButtonShowMore_Click(object sender, EventArgs e)
        {
            List<String> PodcastInfoTempList = MainLogic.GetPodcastInfo(ListBoxPodcasts.SelectedItem as Podcast);
            ShowMorePodcastInfo PodcastInfoWindow = new ShowMorePodcastInfo(PodcastInfoTempList);
            PodcastInfoWindow.Show();
        }

        public void updateComboboxes()
        {
            MainLogic.UpdateComboBoxes(ComboBoxCategory, ComboBoxCategory);
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxFeeds.Items.Clear();
            ListBoxPodcasts.Items.Clear();

            MainLogic.set_selected_category(ComboBoxCategory.SelectedItem.ToString());
            MainLogic.FillListBoxFeeds(ListBoxFeeds);
        }

        private void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            MainLogic.StartPauseAudio();
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
                    MainLogic.ManageFeed(FeedToChange, "Name", TextBoxManageFeedName.Text);
                }
                if (hasValueURL)
                {
                    validator.validateUrl(TextBoxManageFeedURL.Text);
                    MainLogic.ManageFeed(FeedToChange, "URL", TextBoxManageFeedURL.Text);
                }
                if (hasValueInterval)
                {
                    validator.validateInterval(TextBoxManageFeedUpdateInterval.Text);
                    MainLogic.ManageFeed(FeedToChange, "UpdateInterval", TextBoxManageFeedUpdateInterval.Text);
                }
                MainLogic.ManageFeed(FeedToChange, "Category", NewCategory);
                ReloadListBoxes();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        
        private void ButtonQuitMusicPlayback_Click(object sender, EventArgs e)
        {
            MainLogic.QuitMusicPlayer();
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
                MainLogic.FillListBoxPodcasts(ListBoxPodcasts, SelectedFeed);
            }
        }

        private void ButtonManageCategoriesRemove_Click(object sender, EventArgs e)
        {
            var ChoosenCategory = ComboBoxManageCategories.SelectedItem.ToString();
            MainLogic.removeCategory(ChoosenCategory);
            MessageBox.Show(ChoosenCategory + " har tagits bort som kategori");
            MainLogic.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
        }

        private void ButtonManageCategoriesSave_Click(object sender, EventArgs e)
        {
            var NewName = TextBoxManageCategoriesNewName.Text;
            var OldName = ComboBoxCategory.SelectedItem.ToString();

            try 
            {
                validator.validateCategory(NewName, MainLogic.getCategoryList());
                MainLogic.ChangeCategoryName(NewName, OldName);
                MainLogic.SaveCategories();
                MainLogic.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
                MessageBox.Show(OldName + " har döpts om till " + NewName);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonManageCategoriesCreate_Click(object sender, EventArgs e)
        {
            var NewCategory = TextBoxAddCategory.Text;
            MainLogic.AddCategoryName(NewCategory);
            MainLogic.SaveCategories();
            MainLogic.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
            MessageBox.Show(NewCategory + " har lagts till som ny kategori");
            TextBoxAddCategory.Clear();
        }

    }
}
