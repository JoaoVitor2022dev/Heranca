using System;
using System.Globalization;
using Primeiro.Entities;

namespace Primeiro
{
    class Program
    {
       static void Main()
        {
           Account acc = new Account(3456, "joao vitor", 59.90);
           
           BusinessAcount bacc = new BusinessAcount(3980, "vitor lima", 345.90, 1000);

           // upcasting 

           Account acc1 = bacc; 
           Account acc2 = new BusinessAcount(1003, "bob", 0.0 , 200.0);
           Account acc3 = new SavingsAccount(3078, "Anna", 0.0, 0.01);

           // donwcasting

           BusinessAcount acc4 = (BusinessAcount)acc2; 
           acc4.Loan(100.0);

           //  BusinessAcount acc5 = (BusinessAcount)acc3; - nao esta correto esta operaçao 

           if (acc3 in BusinessAcount)
           {
               // BusinessAcount acc5 = (BusinessAcount)acc3;
               BusinessAcount acc5 = acc3 as BusinessAcount;
               acc5.Loan(200.0);
           }
           
           if (acc3 in SavingsAccount)
           {
              // SavingsAccount acc5 = (SavingsAccount)acc3;
              SavingsAccount acc5 = acc3 as SavingsAccount;
              acc5.UpdateBalance();
              Console.WriteLine("Update !");
           }  
        }
    }
}

