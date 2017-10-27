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
            listBox1.DisplayMember = "Title";
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

            FormHandler.SendInput(tbNamn.Text, tbURL.Text, cbCategory.SelectedItem.ToString(), 1);
            FormHandler.FillListBox(listBox1);
            FormHandler.HandleXMLSaving();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_manage_categories manageCat = new form_manage_categories();
            manageCat.Show();

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Podcast SelectedPodcast = listBox1.SelectedItem as Podcast;

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
            List<String> PodcastInfoTempList = FormHandler.GetPodcastInfo(listBox1.SelectedItem as Podcast);
            ShowMorePodcastInfo PodcastInfoWindow = new ShowMorePodcastInfo(PodcastInfoTempList);
            PodcastInfoWindow.Show();
            
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FormHandler.set_selected_category(cbCategory.SelectedItem.ToString());
            FormHandler.FillListBox(listBox1);
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
        }
    }
}
