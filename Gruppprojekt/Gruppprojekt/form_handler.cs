using System;
using System.Collections.Generic;
using System.Linq;
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
                listbox.Items.Add(pc.Title);
            }
        }

        public void SendInput(string name, string url, string category, int update_intervall)
        {
            List<Podcast> temper = new List<Podcast>();
            temper = u_f_c.Create_Podcast(name, url, category, update_intervall);
            foreach (Podcast pc in temper)
            {
                p_h.add_podcast(pc);
            }
        }
    }
}
