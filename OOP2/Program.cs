using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muhammet Emin Aslangil
            IndividualCustomer individual1 = new IndividualCustomer();
            individual1.Id = 1;
            individual1.CustomerNumber = "12345";
            individual1.Name = "Muhammet";
            individual1.LastName ="Aslangil";
            individual1.TcNumber = "12345678910";

            // XYZ Company
            CorporateCustomer corporate1 = new CorporateCustomer();
            corporate1.Id = 2;
            corporate1.CustomerNumber = "54321";
            corporate1.CompanyName = "XYZ";
            corporate1.TaxNumber ="1234567890";

            // SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individual1);
            customerManager.Add(corporate1);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}
