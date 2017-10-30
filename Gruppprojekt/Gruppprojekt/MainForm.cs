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

        public MainForm()
        {
            InitializeComponent();
            FormHandler = new Form_Handler();
            Categories categ = new Categories();
            List<String> categoryList = categ.getList();
            categ.fillCategoryCB(categoryList, cbCategory);
            categ.fillCategoryCB(categoryList, cbCategory2);
            ListBoxFeeds.DisplayMember = "Name";
            ListBoxPodcasts.DisplayMember = "Title";
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

            string Name = tbNamn.Text;
            string URL = tbURL.Text;
            string Category = cbCategory2.SelectedItem.ToString();
            int UpdateInterval = 1;

            FormHandler.SendInput(Name, URL, Category, UpdateInterval);
            ListBoxFeeds.Items.Clear();
            FormHandler.FillListBoxFeeds(ListBoxFeeds);
            FormHandler.HandleXMLSaving();

            tbNamn.Clear();
            tbURL.Clear();
            MessageBox.Show("Success!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_manage_categories manageCat = new form_manage_categories();
            manageCat.Show();

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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxFeeds.Items.Clear();
            ListBoxPodcasts.Items.Clear();
            FormHandler.set_selected_category(cbCategory.SelectedItem.ToString());
            FormHandler.FillListBoxFeeds(ListBoxPodcasts);
        }

        private void btPlayPause_Click(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {

            FormHandler.LoadXMLSaving();
            FormHandler.FillListBoxFeeds(ListBoxPodcasts);
        }

        private void ListBoxFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListBoxPodcasts.Items.Clear();
            Feed SelectedFeed = ListBoxFeeds.SelectedItem as Feed;
            FormHandler.FillListBoxPodcasts(ListBoxPodcasts, SelectedFeed);
        }
    }
}
