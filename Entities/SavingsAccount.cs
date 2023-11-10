using System;
using System.Globalization;

namespace Primeiro.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {}

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
          InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;    
        }

        public override void Withdraw(double amount)
        {
           //  neste caso é para fazer o sistema de pegar um metodo da superclasse
           base.Withdraw(amount); 
           Balance -= amount; 
        }
    }
}