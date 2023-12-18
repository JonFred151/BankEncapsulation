using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        // set up a private double that the user can not directly touch. with the other being use for other methods
        private double Balance = 0;
        double amount;
        // setup the balance
        public BankAccount()
        {
            Balance = amount;
        }
        //deposit money into balance
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        //gets the balance
        public double GetBalance()
        {
            return Balance;
        }
        //withdraw from balance
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }






    }
}
