using System;
using System.Globalization;
using Primeiro.Entities;

namespace Primeiro
{
    class Program
    {
       static void Main()
        { 
        Account acc1 = new Account(2345, "joao vitor", 500.0);
        Account acc2 = new SavingsAccount(5467, "joao vitor", 500.0, 0.01);

        acc1.Withdraw(10.0);
        acc2.Withdraw(10.0);

          Console.WriteLine(acc1.Balance);
          Console.WriteLine(acc2.Balance);

          // regras de negocio... 

          // conta comum: é conbrada um taxa no valor de 5.00 

          // conta poupaça: nao é cobrada taxa; 

          // sobreposiçao, é modificar um tipo de funcionalidade dentro 


        }
    }
}

