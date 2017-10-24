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

        }
        public void fill_list_box(ListBox listbox)
        {
            foreach (Podcast pc in p_h.get_podcast_list())
            {
                listbox.Items.Add(pc.Title);
            }
        }

        public void Create_podcast(string name, string url, string category, int update_intervall)
        {
            u_f_c.Create_Podcast(p_h, name, url, category, update_intervall);
        }
    }
}
