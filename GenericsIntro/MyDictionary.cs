using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<T1,T2>
    {
        T2[] newItems;
        T2[] tempItems;
        
        public MyDictionary()
        {
            newItems = new T2[0];
            tempItems = new T2[0];
        }            

        public void Add(int key, T2 value)
        {
            /* For adding to the dictionary
             * If the entered key value is greater than or equal to the number of dictionary elements,
             * the array size is sufficiently increased and the value added.
             * 
             * If the key value entered is less than or equal to the number of dictionary elements and the key value is greater than or equal to zero,
             * the value is placed in the specified key.
             * 
             * In cases where the key value is less than zero, an error message will be issued.
             * */

            if (key>=newItems.Length)
            {
                int increaseAmount = (key - (newItems.Length - 1));
                tempItems = newItems;
                newItems = new T2[newItems.Length + increaseAmount];

                for (int i = 0; i < tempItems.Length; i++)
                {
                    newItems[i] = tempItems[i];
                }
                newItems[newItems.Length - 1] = value;
            }

            else if(key<=newItems.Length && key>=0)
            {
                newItems[key] = value;
            }
            else
            {
                Console.WriteLine("Dictionary size error ... Minimum key value is zero");
            }
           
        }
        public int Count()
        {
            //The count method is used to find the number of elements in the dictionary.        
            return newItems.Length;
        }
    }
}
