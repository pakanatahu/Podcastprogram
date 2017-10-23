using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppprojekt
{
    public partial class add_feed_form : Form
    {
        public add_feed_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            URL_feed_controller feedController = new URL_feed_controller();
            feedController.Get_RSS("http://www.aftonbladet.se/rss.xml");
          //  listBox1.Items.Add(U_c.Get_RSS());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
