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
        private form_handler f_h = new form_handler();
        public add_feed_form()
        {
            f_h = new form_handler();
            InitializeComponent();
            Categories categ = new Categories();
            List<String> categoryList = categ.getList();
            categ.fillCategoryCB(categoryList, cbCategory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_h.Create_podcast(tbNamn.Text, tbURL.Text,cbCategory.SelectedItem.ToString(), 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
