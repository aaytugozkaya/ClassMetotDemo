using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.BankAccountNo + " hesap nolu musteri eklendi!");
        }
    
        public void CustomerRemove(Customer customer)
        {
            Console.WriteLine(customer.BankAccountNo +" numarali musteri silindi!");
        }
    
        public void CustomerUpdate(Customer customer)
        {
            Console.WriteLine(customer.NameSurname + " isimli musterinin bilgileri guncellendi!");
        }
        public void Listing(Customer[] customers)
        {

           foreach (Customer inform in customers)
           {
             Console.WriteLine(inform.Id);
           }
                    
               
        }
    
    }

}
