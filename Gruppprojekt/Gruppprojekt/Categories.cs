using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppprojekt
{
    class Categories
    {

        private List<String> categoryList = new List<String>();

        public Categories()
        {
            addCategories();
        }

        public List<String> getList()
        {
            return categoryList;
        }

        public void removeCategory(String name)
        {
            categoryList.Remove(name);
        }

        public void addNewCategory(String name)
        {
            categoryList.Add(name);
        }

        public void fillCategoryCB(List<String> list, ComboBox cb)
        {
            for (int i = 0; i < list.Count; i++)
            {
                cb.Items.Add(list[i]);
            }
            cb.SelectedIndex = 0;
        }

        private void addCategories()
        {
            categoryList.Add("Thriller");
            categoryList.Add("Sport");
            categoryList.Add("Komedi");
            categoryList.Add("Vetenskap");
            categoryList.Add("Nyheter");
            categoryList.Add("Politik");
            categoryList.Add("Musik");
        }
    }
}
