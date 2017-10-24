using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppprojekt
{
    class form_handler
    {
        private podcast_handler p_h = new podcast_handler();
        private URL_feed_controller u_f_c = new URL_feed_controller();

        public form_handler()
        {
            p_h = new podcast_handler();
            u_f_c = new URL_feed_controller();
        }
        public void fill_list_box(ListBox listbox)
        {
            List<Podcast> temp2 = p_h.get_podcast_list();
            foreach (Podcast pc in temp2)
            {
                listbox.Items.Add(pc);
            }
        }

        public void SendInput(string name, string url, string category, int update_intervall)
        {

            //TODO fixa uppdaterings frekvens.
            List<Podcast> temper = new List<Podcast>();
            temper = u_f_c.Create_Podcast(name, url, category, update_intervall);
            foreach (Podcast pc in temper)
            {
                p_h.add_podcast(pc);
            }
        }

        public List<String> GetPodcastInfo(Podcast SelectedPodcast)
        {
            List<String> PodcastInfoList = new List<String>(new String[] { SelectedPodcast.Name,
                SelectedPodcast.Title, SelectedPodcast.Playurl, SelectedPodcast.Listen_Count.ToString(),
                SelectedPodcast.Update_Intervall.ToString() });

            return PodcastInfoList;
        }

        public void PlayAudio(Podcast SelectedPodcast)
        {
            //TODO - fixa nerladdning.

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(new System.Uri(SelectedPodcast.Playurl),
                "C:\\" + SelectedPodcast.Title + ".mp3");
            }   

        }

    }
}
