using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class Directory_Handler
    {
        public void CreateProgramRootDirectory()
        {
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\PodcastProgram");
        }
        public void CreateMP3DownloadDirectory()
        {

            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\PodcastProgram\\DownloadedPodcasts");
        }

        public void CreateXMLSaveDirectory()
        {

            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\PodcastProgram\\SavedPodcasts");
        }

        public String GetPlayableMP3File(Podcast SelectedPodcast)
        {

            return Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\PodcastProgram\\DownloadedPodcasts\\" + SelectedPodcast.Title + ".mp3";
        } 

        public String GetSavedXMLFile()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\PodcastProgram\\SavedPodcasts\\";
        }

        public void SaveXMLFile()
        {

        }
    }
}
