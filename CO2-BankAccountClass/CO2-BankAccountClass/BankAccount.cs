using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_BankAccountClass
{
    internal class BankAccount
    {
        public string IBAN { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string IBAN, decimal Balance)
        {
            if (string.IsNullOrWhiteSpace(IBAN)) throw new ArgumentNullException("Not valid IBAN");
            if (Balance < 0) throw new ArgumentOutOfRangeException("Balance is not valid");
            this.IBAN = IBAN;
            this.Balance = Balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0) { throw new ArgumentOutOfRangeException("Not valid amount"); }
            this.Balance += amount;



        }
        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance) { throw new InvalidOperationException("Not enough money"); }
            this.Balance -= amount;
        }
        public override string ToString()
        {
            return $"IBAN: {IBAN}, Balance: {Balance:F2}";
        }

    }
}
