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
    public partial class form_manage_categories : Form
    {
        Categories categ = new Categories();
        List<ComboBox> boxlist = new List<ComboBox>();

        public form_manage_categories()
        {
            InitializeComponent();

            List<String> categoryList = categ.getList();
            categ.fillCategoryCB(categ.getList(), cbCategory);
            categ.fillCategoryCB(categ.getList(), cbCategory2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeName(tbNewName.Text, cbCategory.SelectedItem.ToString());
            cbCategory.Items.Clear();
            cbCategory2.Items.Clear();
            categ.fillCategoryCB(categ.getList(), cbCategory);
            categ.fillCategoryCB(categ.getList(), cbCategory2);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeName(String newName, String oldName)
        {
            categ.removeCategory(oldName);
            categ.addNewCategory(newName);


        }

        private void updateComboBoxes( List<String> categories, ComboBox cb)
        {

            cb.Items.Clear();
            categ.fillCategoryCB(categ.getList(), cbCategory);
            categ.fillCategoryCB(categ.getList(), cbCategory2);

        }
    }
}
