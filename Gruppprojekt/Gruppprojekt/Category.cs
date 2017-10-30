using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gruppprojekt
{
    class Category
    {
        private String name;
        public String Name {
            get { return this.name; }
            set { this.name = value; }
        }


        public Category(String categoryName)
        {
            name = categoryName;
        }

    }
}
