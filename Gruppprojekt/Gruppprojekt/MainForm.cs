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
        Form_Handler FormHandler = new Form_Handler();
        Validator validator = new Validator();
        
        public MainForm()
        {
            InitializeComponent();

            ListBoxPodcasts.DisplayMember = "Title";
            ListBoxFeeds.DisplayMember = "Name";
            ComboBoxManageFeed.DisplayMember = "Name";
            CheckForXMLLoadFile();
            FormHandler.CreateStandardCategoryXMLFile();
            FormHandler.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
            FormHandler.FillListBoxFeeds(ListBoxFeeds);
            FormHandler.FillFeedCombobox(ComboBoxManageFeed);
            FormHandler.LoadAllBackgroundWorkers();
        }
        private void CheckForXMLLoadFile()
        {
            if(FormHandler.SavedPodcastListExists())
            {
                FormHandler.LoadXMLSaving();
            }
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
            try { 

                string Name = TextBoxAddRSSName.Text;
                string URL = TextBoxAddRSSURL.Text;
                string Category = ComboBoxAddRSS.SelectedItem.ToString();
                string UpdateInterval = TextBoxAddRSSIntervall.Text;
            
                FormHandler.CreateNewFeed(Name, URL, Category, UpdateInterval);
                ListBoxFeeds.Items.Clear();
                FormHandler.HandleXMLSaving();
                FormHandler.FillListBoxFeeds(ListBoxFeeds);

                TextBoxAddRSSName.Clear();
                TextBoxAddRSSURL.Clear();
                TextBoxAddRSSIntervall.Text = "HH:MM";

                MessageBox.Show("Podcastfeed tillagd!");

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void ButtonPlay_Click(object sender, EventArgs e)
        {
            Podcast SelectedPodcast = ListBoxPodcasts.SelectedItem as Podcast;

            Task<String> DownloadMP3Task = FormHandler.DownloadAudioHandler(SelectedPodcast);
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
            List<String> PodcastInfoTempList = FormHandler.GetPodcastInfo(ListBoxPodcasts.SelectedItem as Podcast);
            ShowMorePodcastInfo PodcastInfoWindow = new ShowMorePodcastInfo(PodcastInfoTempList);
            PodcastInfoWindow.Show();
        }

        public void updateComboboxes()
        {
            FormHandler.UpdateComboBoxes(ComboBoxCategory, ComboBoxCategory);
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxFeeds.Items.Clear();
            ListBoxPodcasts.Items.Clear();

            FormHandler.set_selected_category(ComboBoxCategory.SelectedItem.ToString());
            FormHandler.FillListBoxFeeds(ListBoxFeeds);
        }

        private void ButtonPlayPause_Click(object sender, EventArgs e)
        {
            FormHandler.StartPauseAudio();
        }

        private void ButtonManageFeeds_Click(object sender, EventArgs e)
        {
            FormHandler.StartPauseAudio();
        }
        
        private void ButtonQuitMusicPlayback_Click(object sender, EventArgs e)
        {
            FormHandler.QuitMusicPlayer();
            ButtonQuitMusicPlayback.Visible = false;
            ButtonPlayPause.Visible = false;
            ButtonPlay.Visible = true;
            lbNowPlaying.Text = "";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FormHandler.StartPauseAudio();
        }
        

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormHandler.LoadXMLSaving();
            
        }

        private void ListBoxFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {

            Feed SelectedFeed = ListBoxFeeds.SelectedItem as Feed;

            ListBoxPodcasts.Items.Clear();
            FormHandler.FillListBoxPodcasts(ListBoxPodcasts, SelectedFeed);
        }

        private void ButtonManageCategoriesRemove_Click(object sender, EventArgs e)
        {
            var ChoosenCategory = ComboBoxManageCategories.SelectedItem.ToString();
            FormHandler.removeCategory(ChoosenCategory);
            MessageBox.Show(ChoosenCategory + " har tagits bort som kategori");
            FormHandler.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
        }

        private void ButtonManageCategoriesSave_Click(object sender, EventArgs e)
        {
            var NewName = TextBoxManageCategoriesNewName.Text;
            var OldName = ComboBoxCategory.SelectedItem.ToString();

            try 
            {
                validator.validateCategory(NewName, FormHandler.getCategoryList());
                FormHandler.ChangeCategoryName(NewName, OldName);
                FormHandler.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
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
            FormHandler.AddCategoryName(NewCategory);
            FormHandler.SaveCategories();
            FormHandler.UpdateComboBoxes(ComboBoxCategory, ComboBoxAddRSS, ComboBoxManageCategories);
            MessageBox.Show(NewCategory + " har lagts till som ny kategori");
            TextBoxAddCategory.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonManageFeedRemove_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxAddRSS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
