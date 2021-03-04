using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Id = 1;
            person1.firstName ="Muhammet";
            person1.lastName ="Aslangil";
            

            Customer customer1 = new Customer();
            customer1.Id =2;
            customer1.firstName ="Kenan";
            customer1.lastName ="İmirzalıoğlu";
            customer1.creditCardNumber ="1111111111";


            Employee employee1=new Employee();
            employee1.Id = 3;
            employee1.firstName = "Mahmut";
            employee1.lastName ="Hoca";
            employee1.employeeNumber = 22222;
            
            //person1 = customer1;
            //person1 = employee1;
            //customer1 = employee1;
            //customer1 = person1;

            //Console.WriteLine(((Customer)person1).creditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);



        }
    }
    class Person
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    class Customer : Person
    {
        public string creditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int employeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.firstName);
        }
    }
}
