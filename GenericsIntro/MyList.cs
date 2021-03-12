using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        T[] tempArray;


        public MyList()
        {
            items = new T[0];
            
        }
        public void Add(T item)
        {
            /* To add to the list
             * For each new element sent to the list, the list size increases by one and the element is added.
             * */
            tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        
        public int Count()
        {
            //Count method is used to find out the number of elements of the list.    
            return items.Length;
        }
    }
}
