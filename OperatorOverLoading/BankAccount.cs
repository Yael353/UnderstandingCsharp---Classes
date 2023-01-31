using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    internal class BankAccount
    {
        private double money;
        private string owner;

        public BankAccount(double money, string owner)
        {
            this.money = money;
            this.owner = owner;
        }

        public double Money
        {
            get
            {
                return money;
            }
        }
        public string Owner
        {
            get
            {
                return owner;
            }
        }
        public static BankAccount operator +(BankAccount bank1, BankAccount bank2) // overloading 
        {
            double newAmountOfMoney = bank1.money+ bank2.money;
            string newOwners = bank1.owner + bank2.owner;

            BankAccount newBnkAccount = new BankAccount(newAmountOfMoney, newOwners);
            return newBnkAccount;
        }
        public static BankAccount operator +(BankAccount bank1, double amount) // overloading 
        {
            double newAmountOfMoney = bank1.money + amount;
            string newOwners = bank1.owner;

            BankAccount newBnkAccount = new BankAccount(newAmountOfMoney, newOwners);
            return newBnkAccount;
        }
    }
}
