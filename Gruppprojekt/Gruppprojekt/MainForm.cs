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
            AddDefaultCategories adc = new AddDefaultCategories();
            FormHandler.updateComboBoxes(cbCategory, cbCategory2, cbCategory3);
            ListBoxPodcasts.DisplayMember = "Title";
            ListBoxFeeds.DisplayMember = "Name";
            ComboBoxFeeds.DisplayMember = "Name";
            FormHandler.LoadAllBackgroundWorkers();
            FormHandler.FillFeedCombobox(ComboBoxFeeds);
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

        private void button8_Click(object sender, EventArgs e)
        {
            try { 

                string Name = tbNamn.Text;
                string URL = tbURL.Text;
                string Category = cbCategory2.SelectedItem.ToString();
                string UpdateInterval = tbIntervall.Text;
            
                FormHandler.SendInput(Name, URL, Category, UpdateInterval);
                ListBoxFeeds.Items.Clear();
                FormHandler.FillListBoxFeeds(ListBoxFeeds);
                FormHandler.HandleXMLSaving();

                tbNamn.Clear();
                tbURL.Clear();
                MessageBox.Show("Success!");

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Podcast SelectedPodcast = ListBoxPodcasts.SelectedItem as Podcast;

            Task<String> DownloadMP3Task = FormHandler.DownloadAudioHandler(SelectedPodcast);
            lbNowPlaying.Text = "Laddar ner...";

            await DownloadMP3Task;

            lbNowPlaying.Text = DownloadMP3Task.Result;

            btQuitMusicPlayback.Visible = true;
            btPlayPause.Visible = true;
            btPlay.Visible = false;
            lbNowPlaying.Text = "Spelar upp...";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<String> PodcastInfoTempList = FormHandler.GetPodcastInfo(ListBoxPodcasts.SelectedItem as Podcast);
            ShowMorePodcastInfo PodcastInfoWindow = new ShowMorePodcastInfo(PodcastInfoTempList);
            PodcastInfoWindow.Show();
        }

        public void updateComboboxes()
        {
            FormHandler.updateComboBoxes(cbCategory, cbCategory);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxFeeds.Items.Clear();
            ListBoxPodcasts.Items.Clear();

            FormHandler.set_selected_category(cbCategory.SelectedItem.ToString());
            FormHandler.FillListBoxFeeds(ListBoxFeeds);
        }

        private void btPlayPause_Click(object sender, EventArgs e)
        {
            FormHandler.StartPauseAudio();
        }

        private void ButtonManageFeeds_Click(object sender, EventArgs e)
        {
            FormHandler.StartPauseAudio();
        }
        
        private void btQuitMusicPlayback_Click(object sender, EventArgs e)
        {
            FormHandler.QuitMusicPlayer();
            btQuitMusicPlayback.Visible = false;
            btPlayPause.Visible = false;
            btPlay.Visible = true;
            lbNowPlaying.Text = "";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FormHandler.StartPauseAudio();
        }
        

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormHandler.LoadXMLSaving();
            FormHandler.FillListBoxFeeds(ListBoxFeeds);
        }

        private void ListBoxFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {

            Feed SelectedFeed = ListBoxFeeds.SelectedItem as Feed;

            ListBoxPodcasts.Items.Clear();
            FormHandler.FillListBoxPodcasts(ListBoxPodcasts, SelectedFeed);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var valdKategori = cbCategory3.SelectedItem.ToString();
            FormHandler.removeCategory(valdKategori);
            MessageBox.Show(valdKategori + " har tagits bort som kategori");
            FormHandler.updateComboBoxes(cbCategory, cbCategory2, cbCategory3);
        }

        private void btnChangeCategoryName_Click(object sender, EventArgs e)
        {
            var newName = tbNewName.Text;
            var oldName = cbCategory.SelectedItem.ToString();

            try 
            {
                validator.validateCategory(newName, FormHandler.getCategoryList());
                FormHandler.changeCateogoryName(newName, oldName);
                FormHandler.updateComboBoxes(cbCategory, cbCategory2, cbCategory3);
                MessageBox.Show(oldName + " har döpts om till " + newName);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateNewCategory_Click(object sender, EventArgs e)
        {
            var nyKategori = tbAddCategory.Text;
            FormHandler.addCategoryName(nyKategori);
            FormHandler.updateComboBoxes(cbCategory, cbCategory2, cbCategory3);
            MessageBox.Show(nyKategori + " har lagts till som ny kategori");
            tbAddCategory.Clear();
        }

    }
}
