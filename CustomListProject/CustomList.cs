using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] items = new T[4];
       

        public void Add(T item)
        {
            items[0] = item;
        }
    }
}
