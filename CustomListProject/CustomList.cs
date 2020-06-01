using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
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
                if(i < Count && i >= 0)
                {
                return items[i];

                }
                else
                {
                    return items[0];
                }
            }
            set
            {
                if(i < Count && i >= 0)
                {
                items[i] = value;

                }
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
        }

        public bool Remove(T item)
        {
            bool itemIsInList = false;
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    itemIsInList = true;
                    tempItems = new T[Capacity];
                    int k = 0;
                    for (int j = 0; j < Count; j++)
                    {
                        if (j == i)
                        {
                            j++;
                        }

                        tempItems[k] = items[j];

                        k++;
                    }
                    
                    Count--;
                    break;

                }
                
            }
            items = tempItems;
            return itemIsInList;
        }
        public override string ToString()
        {
            string stringToReturn = "";


            for (int i = 0; i < Count; i++)
            {
                stringToReturn += items[i];
                
                stringToReturn += " ";

            }


            return stringToReturn;
        }

        public IEnumerator GetEnumerator()
        {
            
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        public static CustomList<T> operator+(CustomList<T> first,CustomList<T> second)
        {
            CustomList<T> tempItems = new CustomList<T>();

            foreach(T item in first)
            {
                tempItems.Add(item);
            }
            foreach(T item in second)
            {
                tempItems.Add(item);
            }


            for (int i = 0; i < second.Count; i++)
            {
                first.Add(second[i]);
            }
            return first;
        }
        public static CustomList<T> operator-(CustomList<T> first, CustomList<T> second)
        {
            for (int i = 0; i < second.Count; i++)
            {
                for (int j = 0; j < first.Count; j++)
                {
                    if(first[j].Equals(second[i]))
                    {
                        first.Remove(second[i]);
                        break;
                    }
                }
            }
            return first;
        }
        public CustomList<T> ZipLists(CustomList<T> secondList)
        {
            CustomList<T> result = new CustomList<T>();
            switch (Count > secondList.Count)
            {
                case true:
                    for (int i = 0; i < Count; i++)
                    {
                        result.Add(items[i]);
                        if (i < secondList.Count)
                        {
                            result.Add(secondList[i]);

                        }
                    }
                    break;
                case false:
                    for (int i = 0; i < secondList.Count; i++)
                    {
                        if (i < Count)
                        {
                            result.Add(items[i]);

                        }
                        result.Add(secondList[i]);
                    }
                    break;
                default:
                    break;
            }

            return result;
        }

    }
}
