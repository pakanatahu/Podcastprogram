using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    class CategoryHandler
    {
        private static List<Category> categoryList = new List<Category>();


        public CategoryHandler()
        {

        }

        public List<Category> getList()
        {
            categoryList = sortTheList(categoryList);
            return categoryList;
        }

        private List<Category> sortTheList(List<Category> li)
        {
            li = li.OrderBy(x => x.Name).ToList();
            return li;
        }

        public void removeCategory(String name)
        {

            for (int i = 0; i < categoryList.Count; i++)
            {
                if (categoryList[i].Name == name)
                {
                    categoryList.Remove(categoryList[i]);
                }
            }
        }

        public void addNewCategory(String name)
        {
            categoryList.Add(new Category(name));
        }
        public void ClearList()
        {
            categoryList.Clear();
        }

        public void changeName(String newName, String oldName)
        {
            for (int i = 0; i < categoryList.Count; i++)
            {
                Console.Write(categoryList[i]);
                if (categoryList[i].Name == oldName)
                {
                    categoryList[i].Name = newName;
                    break;
                }
            }

        }
    }
}
