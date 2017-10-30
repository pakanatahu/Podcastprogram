using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class AddDefaultCategories
    {
        Form_Handler formHandler = new Form_Handler();


        public AddDefaultCategories()
        {
            defaultCategories(formHandler.getCategoryList());

        }


        private void defaultCategories(List<Category> list)
        {
            if (list.Count == 0)
            {
                list.Add(new Category("Thriller"));
                list.Add(new Category("Sport"));
                list.Add(new Category("Komedi"));
                list.Add(new Category("Vetenskap"));
                list.Add(new Category("Nyheter"));
                list.Add(new Category("Politik"));
                list.Add(new Category("Musik"));
            }

        }
    }
}
