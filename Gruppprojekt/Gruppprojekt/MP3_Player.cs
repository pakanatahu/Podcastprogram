using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Gruppprojekt
{
    class MP3_Player
    {

        WMPLib.WindowsMediaPlayer WindowsPlayer = new WMPLib.WindowsMediaPlayer();
        Boolean Playing;
        public MP3_Player()
        {

        }

        public void LoadMP3File(String MP3URL)
        {
            WMPLib.WindowsMediaPlayer WindowsPlayer = new WMPLib.WindowsMediaPlayer();
            WindowsPlayer.URL = MP3URL;
        }
        public void PlayMP3File()
        {
            WindowsPlayer.controls.play();
            Playing = true;
        }

        public void PauseResumeMP3File()
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

        public void StopMP3File()
        {
            WindowsPlayer.controls.stop();
        }

    }
}
