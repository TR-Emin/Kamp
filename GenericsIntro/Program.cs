using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //The operation of the dictionary and list classes is tested in this section.

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(5, "Ahmet");
            Console.WriteLine(myDictionary.Count());
            myDictionary.Add(6, "Mehmet");
            Console.WriteLine(myDictionary.Count());
            myDictionary.Add(4, "Ayça");
            Console.WriteLine(myDictionary.Count());
            myDictionary.Add(6, "Mehmet");
            Console.WriteLine(myDictionary.Count());
            myDictionary.Add(6, "Mehmet");
            Console.WriteLine(myDictionary.Count());
            Console.WriteLine("-------------------------------------------------");

            MyDictionary<int, string> dictionarySample = new MyDictionary<int, string>();
            dictionarySample.Add(0, "Muhammet");
            dictionarySample.Add(1, "Emin");
            dictionarySample.Add(2, "Aslangil");
            dictionarySample.Add(1, "Muhammet");
            dictionarySample.Add(2, "Muhammet");
            dictionarySample.Add(5, "Muhammet");
            dictionarySample.Add(-1,"Aslangil");

            Console.WriteLine("dictionarysSample's item count: " + dictionarySample.Count() );
            Console.WriteLine("-------------------------------------------------");

            MyList<string> names = new MyList<string>();
            names.Add("Muhammet");
            names.Add("Emin");
            names.Add("Aslangil");
            names.Add("C#");
            names.Add("Muhammet");
            names.Add("Githup");

            Console.WriteLine("names's item count: "+ names.Count()) ;        

        }
    }
}
