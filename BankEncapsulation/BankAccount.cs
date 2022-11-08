using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Deposite amount: {amount, 0:c}");
            _balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}
