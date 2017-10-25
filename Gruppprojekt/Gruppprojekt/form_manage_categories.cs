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

        public form_manage_categories()
        {
            InitializeComponent();
            List<String> categoryList = categ.getList();
            updateComboBox(cbCategory, categoryList);
            categ.fillCategoryCB(categoryList, cbCategory2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeName(tbNewName.Text, cbCategory.SelectedItem.ToString());
            updateComboBox();
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

        private void updateComboBox(ComboBox cb, List<String> li)
        {
            cb.Items.Clear();
            categ.fillCategoryCB(li, cb);
        }
    }
}
