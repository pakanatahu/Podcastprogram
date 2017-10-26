using System;
using System.Collections.Generic;
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
        private Podcast_Handler PodcastHandler = new Podcast_Handler();
        private URL_Feed_Controller URLFeedController = new URL_Feed_Controller();
        private Directory_Handler DirectoryHandler = new Directory_Handler();
        private MP3_Downloader MP3Downloader = new MP3_Downloader();
        private WMPLib.WindowsMediaPlayer WindowsPlayer = new WindowsMediaPlayer();
        private Boolean Playing;
        public string selected_category = "";

        public Form_Handler()
        {
            CreateDirectories();

        }
        public void FillListBox(ListBox listbox)
        {
            List<Podcast> temp2 = PodcastHandler.GetPodcastList();

            foreach (Podcast pc in temp2)
            {
                if (pc.Category == selected_category)
                {
                    listbox.Items.Add(pc);
                }

            }
        }

        public void set_selected_category(string selected_categ)
        {
            selected_category = selected_categ;
        }

        public void SendInput(String Name, String URL, String Category, int UpdateInterval)
        {

            //TODO fixa uppdaterings frekvens.
            List<Podcast> temper = new List<Podcast>();
            temper = URLFeedController.CreatePodcast(Name, URL, Category, UpdateInterval);
            foreach (Podcast pc in temper)
            {
                PodcastHandler.AddPodcast(pc);
            }
        }

        public List<String> GetPodcastInfo(Podcast SelectedPodcast)
        {
            List<String> PodcastInfoList = new List<String>(new String[] { SelectedPodcast.Name,
                SelectedPodcast.Title, SelectedPodcast.Playurl, SelectedPodcast.Listen_Count.ToString(),
                SelectedPodcast.Update_Intervall.ToString() });

            return PodcastInfoList;
        }

        public async Task<string> DownloadAudioHandler(Podcast SelectedPodcast)
        {
            String Titel = SelectedPodcast.Title;
            String PlayURL = SelectedPodcast.Playurl;

            Task<String> DownloadMP3Task = MP3Downloader.DownloadMP3FileAsync(Titel, PlayURL);

            await DownloadMP3Task;

            StartAudio(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DownloadedPodcasts\\" + SelectedPodcast.Title + ".mp3");

            return DownloadMP3Task.Result;
        }

        public void StartAudio(String MP3URL)
        {
            WindowsPlayer.URL = MP3URL;
            WindowsPlayer.controls.play();
            Playing = true;
        }

        public void StartPauseAudio()
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

        public void QuitMusicPlayer()
        {
            WindowsPlayer.controls.stop();
        }

        public void CreateDirectories()
        {
            DirectoryHandler.CreateMP3DownloadDirectory();
        }

    }
}
