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
        public MainForm()
        {

            InitializeComponent();
            Categories categ = new Categories();
            List<String> categoryList = categ.getList();
            categ.fillCategoryCB(categoryList, cbCategory);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            add_feed_form feedform = new add_feed_form();
            feedform.Show();

        }
    }
}
