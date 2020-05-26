using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] items;
        private T[] tempItems;
        private int count;
        private int capacity;
        public int Count { get { return count; } set { count = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
            
        }
       

        public void Add(T item)
        {
            if (Capacity == Count)
            {
                Capacity += Capacity;
                tempItems = new T[Capacity];

                for (int i = 0; i < Count; i++)
                {
                    tempItems[i] = items[i];
                }

                items = tempItems;          

            }
          
                items[Count] = item;
                Count++;
          
            // inserting into the array
            //if count and capacity are equal
            //then increase capacity
            // copy values over to new array
        }

        public void Remove(T item)
        {         
            for (int i = 0; i < Count; i++)
            {
                if(items[i].Equals(item))
                {

                    Count--;
                    break;
                }
            }
        }
    }
}
