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
    public partial class MainForm : Form
    {
        form_handler f_handler = new form_handler();
        public MainForm()
        {

            InitializeComponent();
            f_handler = new form_handler();
            Categories categ = new Categories();
            List<String> categoryList = categ.getList();
            categ.fillCategoryCB(categoryList, cbCategory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_feed_form feedform = new add_feed_form();
            feedform.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            f_handler.fill_list_box(listBox1);
        }
    }
}
