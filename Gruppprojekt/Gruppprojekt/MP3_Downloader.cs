using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class MP3_Downloader
    {

        public async Task<string> DownloadMP3FileAsync(String PodcastTitle, String PodcastURL)
        {
            using (WebClient client = new WebClient())
            {
                var url = PodcastURL;
                await client.DownloadFileTaskAsync(new Uri(url), Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DownloadedPodcasts\\" + PodcastTitle + ".mp3");
                return "Spelar upp...";
            }
        }


    }

}
