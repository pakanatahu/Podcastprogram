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
        Validator validator = new Validator();
        Form_Handler formHandler = new Form_Handler();

        public form_manage_categories()
        {
            InitializeComponent();

            formHandler.fillCategoryComobox(cbCategory);
            formHandler.fillCategoryComobox(cbCategory2);
            setSelectedIndexComboboxes(cbCategory, cbCategory2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var newName = tbNewName.Text;
            var oldName = cbCategory.SelectedItem.ToString();

            if (!String.IsNullOrWhiteSpace(newName))
            {
                try
                {
                    validator.validateCategoryName(newName, formHandler.getCategoryList());
                    formHandler.changeCateogoryName(newName, oldName);
                    updateComboBoxes();
                    MessageBox.Show(oldName + " har döpts om till " + newName);
                    setSelectedIndexComboboxes(cbCategory, cbCategory2);
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
            this.Close();
        }



        private void updateComboBoxes()
        {

            cbCategory.Items.Clear();
            cbCategory2.Items.Clear();
            formHandler.fillCategoryComobox(cbCategory);
            formHandler.fillCategoryComobox(cbCategory2);
            setSelectedIndexComboboxes(cbCategory, cbCategory2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nyKategori = tbAddCategory.Text;
            formHandler.addCategoryName(nyKategori);
            updateComboBoxes();
            MessageBox.Show(nyKategori + " har lagts till som ny kategori");
            tbAddCategory.Clear();
            setSelectedIndexComboboxes(cbCategory, cbCategory2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var valdKategori = cbCategory2.SelectedItem.ToString();
            formHandler.removeCategory(valdKategori);
            MessageBox.Show(valdKategori + " har tagits bort som kategori");
            updateComboBoxes();
            setSelectedIndexComboboxes(cbCategory, cbCategory2);
        }

        private void setSelectedIndexComboboxes(ComboBox cb1, ComboBox cb2)
        {
            formHandler.setSelectedCategoryInCombobox(cb1, 0);
            formHandler.setSelectedCategoryInCombobox(cb2, 0);
        }
    }
}
