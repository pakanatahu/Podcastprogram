using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class Directory_Handler
    {

        public void CreateMP3DownloadDirectory()
        {
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DownloadedPodcasts");
        }

        public String GetPlayableMP3File(Podcast SelectedPodcast)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DownloadedPodcasts\\" + SelectedPodcast.Title + ".mp3";
        } 
    }
}
