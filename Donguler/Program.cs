using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array - dizi

            string[] kurslar = new string[]{ "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya Başlamak İçin Temel Kurs","Java Kursu"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitt foreach başladı");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");

            Console.ReadKey();


        }
    }
}
