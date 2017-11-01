using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    public abstract class Data_Entities<T>
    {
        public virtual List<T> List { get; set; }
        public virtual void AddDataToList(T type)
        {

            List.Add(type);
        }

        public virtual void RemoveDataFromList(T type)
        {

            List.Remove(type);
        }

        public virtual List<T> ReturnDataFromList()
        {

            return List;
        }

    }
}
