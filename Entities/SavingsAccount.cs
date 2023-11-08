using System;
using System.Globalization;

namespace Primeiro.Entities
{
    class SavingsAccount
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
    }
}