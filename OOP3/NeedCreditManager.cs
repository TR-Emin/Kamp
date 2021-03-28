using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
