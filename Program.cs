using System;
using System.Globalization;
using Primeiro.Entities;

namespace Primeiro
{
    class Program
    {
       static void Main()
        {
           BusinessAcount account = new BusinessAcount(5689, "joao vitor", 500.0, 1000.0);

           Console.WriteLine(account.Balance);
             
           account.Balance = 1000;  

        }
    }
}

