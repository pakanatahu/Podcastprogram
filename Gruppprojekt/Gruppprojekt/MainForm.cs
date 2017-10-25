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
        form_handler FormHandler = new form_handler();
        public MainForm()
        {

            InitializeComponent();
            FormHandler = new form_handler();
            Categories categ = new Categories();
            List<String> categoryList = categ.getList();
            categ.fillCategoryCB(categoryList, cbCategory);
            categ.fillCategoryCB(categoryList, cbCategory2);
            listBox1.DisplayMember = "Title";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormHandler.SendInput(tbNamn.Text, tbURL.Text, cbCategory.SelectedItem.ToString(), 1);
            FormHandler.fill_list_box(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_manage_categories manageCat = new form_manage_categories();
            manageCat.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormHandler.PlayAudio(listBox1.SelectedItem as Podcast);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<String> PodcastInfoTempList = FormHandler.GetPodcastInfo(listBox1.SelectedItem as Podcast);
            ShowMorePodcastInfo PodcastInfoWindow = new ShowMorePodcastInfo(PodcastInfoTempList);
            PodcastInfoWindow.Show();
            
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
