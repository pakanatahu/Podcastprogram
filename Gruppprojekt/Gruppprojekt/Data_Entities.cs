using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppprojekt
{
    public abstract class Data_Entities<T>
    {

        public abstract void AddDataToList(T type);

        public abstract void RemoveDataFromList(T Type);

        public abstract List<T> ReturnDataFromList();

    }
}
