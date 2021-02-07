using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=101,NameSurname="Aytug xyz",CustomerCity="Bursa",BankAccountNo=20120047 };
            Customer customer2 = new Customer() { Id = 102, NameSurname = "Ahmet xyz ", CustomerCity = "Istanbul", BankAccountNo = 23018004 };
            Customer customer3 = new Customer() { Id = 103, NameSurname = "Ali xyz", CustomerCity = "Ankara", BankAccountNo = 23920048 };
            Customer customer4 = new Customer() { Id = 104, NameSurname = "Veli xyz", CustomerCity = "Bursa", BankAccountNo = 20194646 };
            Customer customer5 = new Customer() { Id = 105, NameSurname = "Fatma xyz", CustomerCity = "Adana", BankAccountNo = 25120015 };
            Customer customer6 = new Customer() { Id = 106, NameSurname = "atma xyz", CustomerCity = "dana", BankAccountNo = 25120016 };
            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[6] {customer1,customer2,customer3,customer4,customer5,customer6 };

            Console.WriteLine("--------Adding Customers--------");
            foreach (var customer in customers)
            {
                
                customerManager.CustomerAdd(customer);
                

            }

            //customerManager.CustomerRemove(customer6);

            //etc............

            
           
            
            //-------------------Thanks.---------------------
           
            
            

            

            
            
            

        }
    }
}
