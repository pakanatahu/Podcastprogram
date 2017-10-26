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
        Validator validator;
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
            var newName = tbNewName.Text;
            var oldName = cbCategory.SelectedItem.ToString();

            if (!String.IsNullOrWhiteSpace(newName))
            {
                try
                {
                    validator.validateCategoryName(newName, categ.getList());
                    changeName(newName, oldName);
                    updateComboBoxes();
                    MessageBox.Show(oldName + " har döpts om till " + newName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Kategorin måste ha ett namn");
            }
            




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

        private void updateComboBoxes()
        {

            cbCategory.Items.Clear();
            cbCategory2.Items.Clear();
            categ.fillCategoryCB(categ.getList(), cbCategory);
            categ.fillCategoryCB(categ.getList(), cbCategory2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nyKategori = tbAddCategory.Text;
            categ.addNewCategory(nyKategori);
            updateComboBoxes();
            MessageBox.Show(nyKategori + " har lagts till som ny kategori");
            tbAddCategory.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var valdKategori = cbCategory2.SelectedItem.ToString();
            categ.removeCategory(valdKategori);
            MessageBox.Show(valdKategori + " har tagits bort som kategori");
            updateComboBoxes();   
        }
    }
}
